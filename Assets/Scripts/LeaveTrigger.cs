using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveTrigger : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelGenerator.instance.AddPiece();
        LevelGenerator.instance.RemoveOldestPiece();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
