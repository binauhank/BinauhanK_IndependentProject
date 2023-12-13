using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScript : MonoBehaviour
{
    public float startSpeed = 6.5f;
    void Start ()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody> ();
        rigidbody.velocity = new Vector3 (startSpeed, 0, startSpeed);
    }
}
