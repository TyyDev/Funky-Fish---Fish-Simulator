using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject PauseUI;

    public bool paused;
    void Start()
    {
        ResumeGame();
        paused = false;
        PauseUI.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (paused == true)
            {
                PauseUI.SetActive(false);
                paused = false;
                ResumeGame();
            }

            else if (paused == false)
            {
                PauseUI.SetActive(true);
                paused = true;
                PauseGame();
            }
        }


    }

    public void menuPressed()
    {
        SceneManager.LoadScene(0);


    }




    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }


}
