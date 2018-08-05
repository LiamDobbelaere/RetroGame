using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    public GameObject BoomBoom;
    public Slider Health;
    public GameObject Player;
    private ScrollTexture groundScroll;
    public AudioClip[] AudioData;
    public GameObject Shadow;
    public Text ScoreBox;
    public int Score;

    public bool Destroyed = false;
	// Use this for initialization
	void Start () {
        groundScroll = GameObject.Find("Ground").GetComponent<ScrollTexture>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Health.value < 1)
        {
            GameObject Explosion = Instantiate(BoomBoom, Player.transform.position, Player.transform.rotation);
            groundScroll.speed.y *= 2;
            groundScroll.speed.x *= 2;
            GameObject.Find("BGM").GetComponent<AudioSource>().Stop();
            GetComponent<AudioTrigger>().Trigger(AudioData[0]);

            Health.value = Health.maxValue;
            StartCoroutine(ReSpawn());
        }
	}

    IEnumerator ReSpawn()
    {
        Player.SetActive(false);
        Shadow.SetActive(false);

        yield return new WaitForSeconds(2);
        GetComponent<Animator>().SetTrigger("Die");
        Player.SetActive(true);
        Shadow.SetActive(true);
        Health.value = Health.maxValue;

        yield return new WaitForSeconds(5);
        groundScroll.speed.y /= 2;
        groundScroll.speed.x /= 2;
    }
    }
