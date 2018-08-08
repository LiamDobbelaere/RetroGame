
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCollision : MonoBehaviour {
    public GameObject BoomBoom;
    public bool Destroyable = false;
	// Use this for initialization
	void OnCollisionEnter (Collision hit) {
		if (hit.gameObject.tag == "Player")
        {
            GameObject.Find("Health").GetComponent<Slider>().value -= 1;
            Debug.Log("HIT");
            GetComponent<Collider>().enabled = false;
        }
        if (hit.gameObject.tag == "PewPew" && Destroyable == true)
        {
            Debug.Log("Hit by Pew Pew");
            GameObject Explosion = Instantiate(BoomBoom, transform.position, transform.parent.rotation);
            Destroy(gameObject.transform.parent.gameObject);
        }
    }

    void OnTriggerEnter(Collider hitit)
    {
        if (hitit.gameObject.tag == "Player")
        {
            Debug.Log("OnTriggaEnte");

            GameObject.Find("Health").GetComponent<Slider>().value -= 1;
            Debug.Log("HIT");
            GetComponent<Collider>().enabled = false;
        }

        

    }

    // Update is called once per frame
    void Update () {
		
	}
}
