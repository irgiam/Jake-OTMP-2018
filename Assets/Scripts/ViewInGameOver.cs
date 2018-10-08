using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewInGameOver : MonoBehaviour {

    public Text gameOverCoinLabel;
    public Text gameOverHighScoreLabel;

    
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.currentGameState == GameState.gameOver)
        {
            gameOverCoinLabel.text = GameManager.instance.collectedCoins.ToString();
            gameOverHighScoreLabel.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f0");
        }
	}
}
