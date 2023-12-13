using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScript : MonoBehaviour
{
    public string sceneToLoad = "test";
    public void LoadGame ()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
