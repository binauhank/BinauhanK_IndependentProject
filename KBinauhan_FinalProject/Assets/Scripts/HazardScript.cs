using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardScript : MonoBehaviour
{
    public bool isHit = false;
    void OnTriggerEnter (Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == "Ball")
        {
            Destroy (collidedWith);
            isHit = true;
        }
    }
    void OnGUI ()
    {
        if (isHit == true)
            {
                Rect boxRect = new Rect(Screen.width / 2 - 75, Screen.height - 200, 150, 25);
                GUI.Box(boxRect, "Ball was destroyed!");
            }
    }
}