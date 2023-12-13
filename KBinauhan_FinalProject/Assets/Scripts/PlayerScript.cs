using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Object prefab;
    public Camera playerCamera;
    public float distance;
    private float wallCooldown;
    private float cooldownTime = 2f;

    void Update()
    {
        if (wallCooldown > 0)
        {
            wallCooldown -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (wallCooldown <= 0)
            {
                wallCooldown = cooldownTime;
                Instantiate(prefab, playerCamera.transform.position + playerCamera.transform.forward * distance, playerCamera.transform.rotation);
            }
        }
    }
}
