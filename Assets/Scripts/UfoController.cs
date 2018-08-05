using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private ScrollTexture groundScroll;
    public bool CanControl = true;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundScroll = GameObject.Find("Ground").GetComponent<ScrollTexture>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (CanControl == true)
        {
            rb.MovePosition(transform.position + new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime,
                Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0.0f));

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.5f, 1.5f), Mathf.Clamp(transform.position.y, -0.61f, 1.8f), transform.position.z);

            if (Mathf.Abs(transform.position.x) > 0.5f)
            {
                groundScroll.speed.x = -transform.position.x * 1.5f;
            }
            else
            {
                groundScroll.speed.x = 0f;
            }
        }
    }
}
