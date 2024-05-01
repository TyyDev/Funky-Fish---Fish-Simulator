using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMenu : MonoBehaviour
{
    public GameObject playerUI;

    public GameObject PauseUI;

    private Menu menu;



    public bool pausedUI;
    void Start()
    {
        menu = PauseUI.GetComponent<Menu>();

        pausedUI = false;
        playerUI.SetActive(false);
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            if (pausedUI == true)
            {
                menu.PauseUI.SetActive(false);
                menu.paused = false;
                

                
                playerUI.SetActive(false);
                pausedUI = false;
                
                 
            }

            else if (pausedUI == false)
            {
                if (menu.paused == true)
                {
                    menu.PauseUI.SetActive(false);
                    menu.paused = false;
                    

                }
               else
                    playerUI.SetActive(true);
                    pausedUI = true;
                    

               
            }
        }

    }

    
}
