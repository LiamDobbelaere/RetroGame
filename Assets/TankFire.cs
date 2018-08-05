using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankFire : MonoBehaviour {
    public GameObject BPre;
    public int Rate;

    public bool Spawn = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Spawn == false)
        {
            StartCoroutine(Spawner());
            Rate = Random.Range(3, 7);
            

        }
        
        }

    IEnumerator Spawner()
    {

        Spawn = true;
        GameObject Beam = Instantiate(BPre, transform.position, transform.rotation);
        Beam.GetComponent<Rigidbody>().AddForce(transform.forward * -4000);
        //BPre.transform.rotation = Quaternion.LookRotation(transform.position - GameObject.Find("ufo").transform.position);
        yield return new WaitForSeconds(Rate);

        Spawn = false;
    }
}
