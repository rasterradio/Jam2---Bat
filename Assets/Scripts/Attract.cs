using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attract : MonoBehaviour
{

    bool batting;
    bool lineOfSight;
    float distance;

    private Rigidbody body;
    public float speed = 1f;
    public Vector3 currPosition;

    GameObject player;
    //GameObject enemy;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.batting == true)
        {
            //If there is nothing blocking line of sight
            if (lookForPlayer() == true)
            {
                //move enemy towards player
                currPosition = transform.position;
                moveEnemy();
            }
        }
    }

    void moveEnemy()
    {
        transform.position = Vector3.MoveTowards(currPosition, PlayerMovement.playerPosition, speed);
    }

    bool lookForPlayer()
    {
        //Vector3 playerDir = this.transform.position - player.transform.position;
        Vector3 playerDir = player.transform.position - transform.position;
        playerDir.Normalize();
        Ray ray = new Ray(this.transform.position, playerDir);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject go = hitInfo.collider.gameObject;
            if (go.name == "Player")
                return true;
            else
                return false;
        }
        else
            return false;
    }
}
