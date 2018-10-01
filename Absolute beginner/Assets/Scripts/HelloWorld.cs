using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {
    public string newName = "The Amazing Cube";
    public string message = "Hello World!";
	void Start () {
        gameObject.name = "spinny boy";
        Debug.Log(gameObject.name + " is in serious pain");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
