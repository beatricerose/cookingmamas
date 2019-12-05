using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float timeScale;
    public static string prevScene;
    bool gameIsPaused = false;
    AudioSource audioSource;

    public void SetPrevScene(string name)
    {
        prevScene = name;
    }

    public string GetPrevScene()
    {
        return prevScene;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (gameIsPaused == true)
            {
                audioSource.UnPause();
                gameIsPaused = false;
                Time.timeScale = 1;
                
            }

            else
            {
                audioSource.Pause();
                gameIsPaused = true;
                Time.timeScale = 0;
                
            }
        }
    }
}
