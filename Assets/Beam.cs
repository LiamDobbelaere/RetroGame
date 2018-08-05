using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour {
    private void Start()
    {
        transform.eulerAngles = new Vector3 (90, 0, 0);
    }
    // Use this for initialization
    void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * 10);
    }
	
	// Update is called once per frame
	void OnCollisionEnter (Collision hit) {
        if (hit.gameObject.tag != "Player" || hit.gameObject.tag != "PewPew")
        {
            Destroy(gameObject);
        }
	}
}
