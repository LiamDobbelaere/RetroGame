using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    private ScrollTexture groundScroll;
    private Material material;
    private Color color;
    public Vector3 StartingVector;

    // Use this for initialization
    void Start () {
        groundScroll = GameObject.Find("Ground").GetComponent<ScrollTexture>();
        transform.position = new Vector3(transform.position.x + Random.Range (-5,5), StartingVector.y, transform.position.z);

        //material = GetComponent<Renderer>().material;
        //color = material.GetColor("_Color");
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(
            groundScroll.speed.x * Time.deltaTime * 1.55f, 
            0, 
            groundScroll.speed.y * Time.deltaTime * 1.55f);

        float a = 0f;
        if (transform.position.z > 22f)
            a = 0.2f;
        else if (transform.position.z > 20f)
            a = 0.4f;
        else if (transform.position.z > 18f)
            a = 0.8f;
        else
            a = 1f;

        color.a = a;
        //material.SetColor("_Color", color);

        if (transform.position.z < -15)
        {
            Destroy(gameObject);
        }
    }
}
