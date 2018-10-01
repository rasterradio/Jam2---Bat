using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour {

    public Texture2D closedEye;
    public Texture2D openEye;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public AudioClip kiss;

    //AudioSource audioData;

    // Use this for initialization
    void Start ()
    {
        //audioData.GetComponent<AudioSource>();
        //audioData.Play();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0) && PlayerMovement.batting == false)
        {
            PlayerMovement.batting = true;
            Cursor.SetCursor(openEye, hotSpot, cursorMode);
            //audioData.Play();
            AudioSource.PlayClipAtPoint(kiss, PlayerMovement.playerPosition);

        }
        else if (Input.GetMouseButtonDown(0) && PlayerMovement.batting == true)
        {
            PlayerMovement.batting = false;
            Cursor.SetCursor(closedEye, hotSpot, cursorMode);
        }
    }
}
