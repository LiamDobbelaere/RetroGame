using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour {
    public Vector2 speed;

    private Material material;

    // Use this for initialization
    void Start () {
        material = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        material.mainTextureOffset = new Vector2(material.mainTextureOffset.x + speed.x * Time.deltaTime, 
            material.mainTextureOffset.y + speed.y * Time.deltaTime);
	}
}
