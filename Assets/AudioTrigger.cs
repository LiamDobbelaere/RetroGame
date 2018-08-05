using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour {
    public GameObject Camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Trigger (AudioClip Audio) {
        Camera.GetComponent<AudioSource>().Stop();
        Camera.GetComponent<AudioSource>().clip = Audio;
        Camera.GetComponent<AudioSource>().Play();
    }
}
