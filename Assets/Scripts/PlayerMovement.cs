using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float horizontal;
    public float vertical;
    private Rigidbody body;
    public float speed = 20f;
    public float speedLimit = 0.7f;

    public static bool batting = false;
    public static Vector2 playerPosition;

	void Start ()
    {
        body = GetComponent<Rigidbody>();
	}

    void Update ()
    {

    }

    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
            body.velocity = new Vector2((Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, 0.8f)) * speedLimit, (Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, 0.8f)) * speedLimit);
        else
            body.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, 0.8f), Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, 0.8f));
        playerPosition = transform.position;
    }

    void doInput()
    {

    }

    bool GetButtonDown(string buttonName)
    {
        return Input.GetButtonDown(buttonName);
    }
}
