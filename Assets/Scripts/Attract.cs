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
            Debug.Log(PlayerMovement.playerPosition);
            currPosition = transform.position;
            moveEnemy();
            //body.velocity = new Vector2(Mathf.Lerp(0, 1f, 0.8f), Mathf.Lerp(0, 1f, 0.8f));
        }		
	}

    void moveEnemy()
    {
        transform.position = Vector3.MoveTowards(currPosition, PlayerMovement.playerPosition, speed);
    }
}
