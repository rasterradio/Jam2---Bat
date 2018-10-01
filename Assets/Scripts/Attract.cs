using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attract : MonoBehaviour {

    bool batting;

    private Rigidbody body;
    public float speed = 1f;
    public Vector3 currPosition;

    // Use this for initialization
    void Start ()
    {

    }


    // Update is called once per frame
    void Update ()
    { 
        if (PlayerMovement.batting == true)
        {
            //move enemy towards player
            currPosition = transform.position;
            moveEnemy();
        }		
	}

    void moveEnemy()
    {
        transform.position = Vector3.MoveTowards(currPosition, PlayerMovement.playerPosition, speed);
    }
}
