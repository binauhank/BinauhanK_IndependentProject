using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneScript : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public GameObject prefab;
    public bool isPressed = false;
    private float ballCooldown;
    private float cooldownTime = 30f;

    void Start()
    {
        cam1.enabled = true;
        cam1.enabled = false;
    }

    void Update()
    {
        if (ballCooldown > 0)
        {
            ballCooldown -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if(ballCooldown <= 0)
            {
                ballCooldown = cooldownTime;
                cam1.enabled = !cam1.enabled;
                cam2.enabled = !cam2.enabled;
                isPressed = true;

                if (SceneManager.GetActiveScene().name == "Level 1")
                {
                    Instantiate (prefab, new Vector3 (14.65f, 25.5f, 35f), transform.rotation);
                }
                if (SceneManager.GetActiveScene().name == "Level 2")
                {
                    Instantiate (prefab, new Vector3 (37f, 25.2f, 52.25f), transform.rotation);
                }
                if (SceneManager.GetActiveScene().name == "Level 3")
                {
                    Instantiate (prefab, new Vector3 (43.9f, 25.35f, 47f), transform.rotation);
                }
                if (SceneManager.GetActiveScene().name == "Level 4")
                {
                    Instantiate (prefab, new Vector3 (9.8f, 25.5f, 25.5f), transform.rotation);
                }
                if (SceneManager.GetActiveScene().name == "Level 5")
                {
                    Instantiate (prefab, new Vector3 (26.2f, 25.5f, 20f), transform.rotation);
                }
            }
        }
    }
}
