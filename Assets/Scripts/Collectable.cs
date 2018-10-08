﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    bool isCollected = false;

    void Show()
    {
        this.GetComponent<SpriteRenderer>().enabled = true; //another method for using component such as rigidbody, collider, etc
        this.GetComponent<CircleCollider2D>().enabled = true;
        isCollected = false;
    }

    void Hide()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<CircleCollider2D>().enabled = false;
    }

    void Collect()
    {
        isCollected = true;
        Hide();
        GameManager.instance.CollectedCoin();
        AudioManager.instance.PlayGetCoin();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Collect();
        }
    }
    
}