using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScript : MonoBehaviour
{
    public float xSpeed;
    public float zSpeed;

    void Start ()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody> ();
        rigidbody.velocity = new Vector3 (xSpeed, 0, zSpeed);
    }
    void Update()
    {
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * 6f;
    }
}
