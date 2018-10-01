using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {
    public string newName = "The Amazing Cube";
    public string message = "Hello World!";

	// Use this for initialization
	void Start () {
        gameObject.name = newName;
        Debug.Log(newName+" says "+message);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
