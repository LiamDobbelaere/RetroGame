using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {
    public GameObject[] Obstacles;
    public GameObject[] Enemies;
    private ScrollTexture groundScroll;
    public float Rate;
    public bool Spawn = true;
    // Use this for initialization

    void Start () {
        groundScroll = GameObject.Find("Ground").GetComponent<ScrollTexture>();
        StartCoroutine(WaitNow());
    }
	
	// Update is called once per frame
	void Update () {
        Rate = 20 / groundScroll.speed.y * -1;
        if (Spawn == false && groundScroll.speed.y != 0)
        {
            StartCoroutine(Spawner());
        }
	}

    IEnumerator Spawner ()
    {
        Spawn = true;

        int binary = Random.Range(0, 2);

            if (binary == 0)
            {
                GameObject Enemy = Instantiate(Enemies[Random.Range(0, Enemies.Length)], transform.position, transform.rotation);
            }

            if (binary == 1)
            {
                GameObject Obstacle = Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], transform.position, transform.rotation);
            }

        yield return new WaitForSeconds(Rate);

        Spawn = false;
    }

    IEnumerator WaitNow()
    {
        yield return new WaitForSeconds(5);
        Spawn = false;
    }
    }
