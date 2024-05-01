using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonPressed : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        


    }

    public void playButtonPressed()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);


    }

}
