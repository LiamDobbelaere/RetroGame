using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyScroll : MonoBehaviour
{
    public ScrollTexture Speed;
    public float scaleFactor;
    private Material material;

    // Use this for initialization
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset = new Vector2(material.mainTextureOffset.x + Speed.speed.x * Time.deltaTime / 32 * -1 * scaleFactor,
            0);
    }
}
