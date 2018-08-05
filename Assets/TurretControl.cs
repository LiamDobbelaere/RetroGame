using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour {

    public Transform UFO;
	// Use this for initialization
	void Start () {
        UFO = GameObject.Find("ufo").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.LookRotation(transform.position - UFO.position);
    }
}
