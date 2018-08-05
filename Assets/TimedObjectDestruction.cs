using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectDestruction : MonoBehaviour {
    public int Time;
	// Use this for initialization
	void Start () {
        StartCoroutine(Delete());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Delete()
    {
        yield return new WaitForSeconds(Time);
        Destroy(gameObject);
       

    }
}
