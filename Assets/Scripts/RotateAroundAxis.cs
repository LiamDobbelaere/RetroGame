using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundAxis : MonoBehaviour {
    public Vector3 speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 angles = transform.localEulerAngles;

        angles = new Vector3(angles.x + speed.x * Time.deltaTime, angles.y + speed.y * Time.deltaTime, angles.z + speed.z * Time.deltaTime);

        transform.localEulerAngles = angles;
	}
}
