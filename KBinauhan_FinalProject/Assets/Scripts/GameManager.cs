using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float gameTime = 30;
    float totalTimeElapsed = 0;
    public LevelOneScript levelScript;
    public FinishZoneScript finishZone;
    bool isGameOver = false;
    bool levelComplete = false;

    void Update()
    {
        Time.timeScale = 1f;

        levelComplete = finishZone.isSolved;

        if (isGameOver)
            return;

        if (levelScript.isPressed == true)
        {
            totalTimeElapsed += Time.deltaTime;
            gameTime -= Time.deltaTime;
            if (gameTime <= 0)
                isGameOver = true;
        }
    }
    
    void OnGUI()
    {
        if (levelScript.isPressed == true)
        {
            if (!isGameOver)
            {
                Rect boxRect = new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 50);
                GUI.Box(boxRect, "Time Remaining");
                Rect labelRect = new Rect(Screen.width / 2 - 8, Screen.height - 80, 20, 40);
                GUI.Label(labelRect, ((int)gameTime).ToString());
            }
            else
            {
                Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 110, 120, 50);
                GUI.Box(boxRect, "Game Over");
                Rect labelRect = new Rect(Screen.width / 2 - 40, Screen.height / 2 - 90, 90, 40);
                GUI.Label(labelRect, "Total Time: " +(int)totalTimeElapsed);
                Rect buttonRect = new Rect(Screen.width / 2 - 40, Screen.height / 2 - 40, 80, 50);
                if (GUI.Button(buttonRect, "Try Again"))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            
                Time.timeScale = 0;
            }

            if(levelComplete)
            {
                Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 110, 120, 50);
                GUI.Box(boxRect, "Level Complete");
                Rect labelRect = new Rect(Screen.width / 2 - 40, Screen.height / 2 - 90, 90, 40);
                GUI.Label(labelRect, "Total Time: " +(int)totalTimeElapsed);
                Rect buttonRect = new Rect(Screen.width / 2 - 40, Screen.height / 2 - 40, 80, 50);
                if (GUI.Button(buttonRect, "Next Level"))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }

                Time.timeScale = 0;
            }
        }
    }
}