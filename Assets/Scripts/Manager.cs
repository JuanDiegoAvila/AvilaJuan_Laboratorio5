using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Manager : MonoBehaviour
{
 
    public static int crystals = 0;
    public Text ScoreText;
    public  FirstPersonController fpsController;

    public GameObject pauseMenu;


    public static int Crystals
    {
        get { return crystals; }
        set { crystals = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        crystals = 0;
        FirstPersonController.Enabled = true;


        pauseMenu.SetActive(false);

        Time.timeScale = 1.0f;


    }

    // Update is called once per frame
    void Update()
    {
    
        ScoreText.text = "Score :  " + Crystals;

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
