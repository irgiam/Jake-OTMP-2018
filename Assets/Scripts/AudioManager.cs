using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioSource jump;
    public AudioSource getCoin;
    public AudioSource gameOver;
    public AudioSource button;
    public static AudioManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlayJump()
    {
        jump.Play();
    }

    public void PlayGetCoin()
    {
        getCoin.Play();
    }

    public void PlayGameOver()
    {
        gameOver.Play();
    }

    public void PlayButton()
    {
        button.Play();
    }
}
