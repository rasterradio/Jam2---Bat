using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attract : MonoBehaviour
{

    bool batting;
    [SerializeField] GameObject anchor;

    private Rigidbody body;
    public float speed = 1f;
    public Vector3 currPosition;
    public LayerMask myMask;

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.batting == true)
        {
            /*//move enemy towards player
            currPosition = transform.position;
            moveEnemy();

            if (Physics2D.Raycast(this.transform.position, anchor.transform.position - this.transform.position, 1000f, myMask))
            {
                RaycastHit2D temp = Physics2D.Raycast(this.transform.position, anchor.transform.position - this.transform.position, 1000f, myMask);
                Debug.Log(temp.transform.gameObject);
                Debug.Log(temp.transform.tag);
                if (temp.transform.tag == "Enemy")
                {   //Call funct
                    Debug.Log("Got here");
                    if (temp.transform.GetComponent<EnemyController>())
                    {
                        temp.transform.GetComponent<EnemyController>().getCharmed(this.transform.position);
                    }
                }

            }*/
            CanSeePlayer();

            
        }
    }

    void moveEnemy()
    {
        transform.position = Vector3.MoveTowards(currPosition, PlayerMovement.playerPosition, speed);
    }

    bool CanSeePlayer()
    {
        //rayDirection = playerObject.transform.position - transform.position;
        if (Physics.Raycast(transform.position, anchor.transform.position - this.transform.position, myMask))
        {
            Debug.Log("Can see player");
            return true;
        }
        else
        {
            Debug.Log("Can't see player");
            return false;
        }
    }
}
