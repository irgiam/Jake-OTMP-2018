using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    public static LevelGenerator instance;
    public List<LevelPiece> levelPrefabs = new List<LevelPiece>(); //all level piece used to copy from. Also noted that Level Peice List coming from Level Piece Class :v
    public Transform levelStartPoint; //Start point of the game
    public List<LevelPiece> pieces = new List<LevelPiece>(); //all level piece that currently in level/ appear on screen

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    public void StartLevel() {
        //pieces = new List<LevelPiece>();
        while (pieces.Count != 0)
        {
            RemoveOldestPiece();
        }
        GenerateFirstPiece();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateFirstPiece()
    {
        for (int i=0; i<3; i++)
        {
            AddPiece();
        }
    }

    public void AddPiece()
    {
        //pick random number
        int randomIndex = Random.Range(0, levelPrefabs.Count);

        //instaniate a copy of random level prefab and store it in pieces variable
        LevelPiece piece = (LevelPiece)Instantiate(levelPrefabs[randomIndex]);
        piece.transform.SetParent(this.transform, false);

        Vector3 spawnPosition = Vector3.zero;

        //position
        if (pieces.Count == 0)
        {
            //first piece
            spawnPosition = levelStartPoint.position;
        }
        else
        {
            //take exit from last piece as a spawn point to new piece
            spawnPosition = pieces[pieces.Count - 1].exitPoint.position;
        }

        piece.transform.position = spawnPosition;
        pieces.Add(piece);
    }

    public void RemoveOldestPiece()
    {
        LevelPiece oldestPiece = pieces[0];
        pieces.Remove(oldestPiece);
        Destroy(oldestPiece.gameObject);
    }

}
