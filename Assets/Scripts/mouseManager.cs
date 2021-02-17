using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class mouseManager : MonoBehaviour
{
    public FirstPersonController fpsController;

    public GameObject pauseMenu;


    void Start()
    {
        
        FirstPersonController.Enabled = true;


        pauseMenu.SetActive(false);

        Time.timeScale = 1.0f;

    }
    void Update()
    {
    
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (pauseMenu)
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);

            FirstPersonController.active = !FirstPersonController.active;

            if (pauseMenu.activeSelf)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            Time.timeScale = pauseMenu.activeSelf ? 0.0f : 1.0f;
        }

    }
}
