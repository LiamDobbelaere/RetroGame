using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    private ScrollTexture groundScroll;
    private List<Material> materials;
    private List<Color> colors;
    public Vector3 StartingVector;

    private float startZ;

    // Use this for initialization
    void Start () {
        groundScroll = GameObject.Find("Ground").GetComponent<ScrollTexture>();
        transform.position = new Vector3(transform.position.x + Random.Range (-5,5), StartingVector.y, transform.position.z);
        materials = new List<Material>();
        startZ = transform.position.z;

        foreach (Renderer rend in GetComponentsInChildren<Renderer>())
        {
            materials.AddRange(rend.materials);
        }

        Debug.Log(materials.Count);

        colors = new List<Color>();
        for (int i = 0; i < materials.Count; i++)
        {
            Color c = materials[i].GetColor("_Color");
            colors.Add(c);

            c.a = 0;

            materials[i].SetColor("_Color", c);
        }
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(
            groundScroll.speed.x * Time.deltaTime * 1.55f, 
            0, 
            groundScroll.speed.y * Time.deltaTime * 1.55f);

        float a = 0.2f;
        float deltaZ = Mathf.Abs(startZ - transform.position.z);
        if (deltaZ < 1f)
            a = 0.2f;
        else if (deltaZ < 2f)
            a = 0.4f;
        else if (deltaZ < 3f)
            a = 0.8f;
        else
            a = 1f;

        for (int i = 0; i < colors.Count; i++)
        {
            Color c = colors[i];
            c.a = a;
            colors[i] = c;

            materials[i].SetColor("_Color", colors[i]);
        }
        
        if (transform.position.z < -15)
        {
            Destroy(gameObject);
        }
    }
}
