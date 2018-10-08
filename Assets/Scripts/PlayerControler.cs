using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    public float jumpForce = 16f;
    private Rigidbody2D rigidBody;
    public Animator animator;
    public float runningSpeed = 3f;
    public static PlayerControler instance;
    public Vector3 startingPosition;

    private void Awake()
    {
        instance = this;
        rigidBody = GetComponent<Rigidbody2D>();
        startingPosition = this.transform.position;
    }

    // Use this for initialization
    public void StartGame () {
        animator.SetBool("isAlive", true);
        this.transform.position = startingPosition;
        CameraFollow.instance.CameraStartingPosition();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.instance.currentGameState == GameState.inGame)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Mouse has been clicked");
                Jump();
            }
            animator.SetBool("isGrounded", IsGrounded());
        }
	}

    private void FixedUpdate()
    {
        if (GameManager.instance.currentGameState == GameState.inGame)
        {
            if (rigidBody.velocity.x < runningSpeed)
            {
                rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y); //we are applying a Vector2 velocity to the rigidbody
            }
        }
        else
        {
            rigidBody.velocity = new Vector2(0, 0);
        }
    }

    void Jump()
    {
        if (IsGrounded())
        {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            AudioManager.instance.PlayJump();
        }
    }

    public LayerMask groundLayer;

    bool IsGrounded()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundLayer.value))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Kill()
    {
        GameManager.instance.GameOver();
        animator.SetBool("isAlive", false);
        AudioManager.instance.PlayGameOver();

        //cek apakah highscore lebih besar dr highscore sebelumnya
        if (PlayerPrefs.GetFloat("highscore", 0) < this.GetDistance())
        {
            //menyimpan highscore baru
            PlayerPrefs.SetFloat("highscore", this.GetDistance());
        }
    }

    public float GetDistance()
    {
        float travelDistance = Vector2.Distance(new Vector2(startingPosition.x, 0), new Vector2(this.transform.position.x, 0));
        return travelDistance;
    }

}
