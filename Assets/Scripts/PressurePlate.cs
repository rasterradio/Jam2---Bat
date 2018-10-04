using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    public static bool pressure;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        pressure = true;
        Debug.Log("ENTER");
        
    }

    private void OnCollisionExit(Collision collision)
    {
        pressure = false;
        Debug.Log("EXIT");
        
    }
}
