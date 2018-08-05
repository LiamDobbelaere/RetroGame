using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter (Collision hit) {
        Destroy(hit.gameObject.transform.parent.gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
