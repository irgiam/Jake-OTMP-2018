using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopStatement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i=0; i<=100; i++)
        {
            if (i == 0)
            {
                Debug.Log("is zero");
            }
            else if (IsEvenOdd(i))
            {
                Debug.Log(i + " is even");
            }
            else
            {
                Debug.Log(i + " is odd");
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool IsEvenOdd(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
