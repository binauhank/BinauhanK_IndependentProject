using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public string sceneToLoad = "Controls";
    public void LoadControls ()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    
    public void ExitGame ()
    {
        Application.Quit();
    }
}