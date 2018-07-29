using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Framerate : MonoBehaviour {
    public int framerate;

	// Use this for initialization
	void Start () {
        Application.targetFrameRate = framerate;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
