using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour {
    public GameObject BPre;
    public Slider value;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") /*&& (value.value - 2) > 0*/)
        {
            GameObject Beam = Instantiate(BPre, transform.position, transform.rotation);
            
            
            //Beam.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 5000);
            GetComponent<AudioSource>().Play();
            //value.value -= 3;
        }
	}
}
