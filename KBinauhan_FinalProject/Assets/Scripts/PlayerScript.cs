using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
