using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState //simply create a new enum, which works like an object and can be passed to the method as a parameter
{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour {
    public GameState currentGameState;
    public static GameManager instance;
    public Canvas menuCanvas;
    public Canvas inGameCanvas;
    public Canvas gameOverCanvas;
    public int collectedCoins = 0;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {
        currentGameState = GameState.menu;
    }

    private void Update()
    {
        /*if (Input.GetButtonDown("s"))
        {
            StartGame();
        }*/
    }

    public void StartGame()
    {
        LevelGenerator.instance.StartLevel();
        SetGameState(GameState.inGame);
        PlayerControler.instance.StartGame();
    }

    public void CollectedCoin()
    {
        collectedCoins++;
    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }

    public void BackToMenu()
    {
        SetGameState(GameState.menu);
    }

    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            menuCanvas.enabled = true;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = false;
        }
        else if (newGameState == GameState.inGame)
        {
            menuCanvas.enabled = false;
            inGameCanvas.enabled = true;
            gameOverCanvas.enabled = false;
        }
        else if (newGameState == GameState.gameOver)
        {
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = true;
        }
        currentGameState = newGameState;
    }
}
