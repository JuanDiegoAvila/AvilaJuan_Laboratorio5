using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    private AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        buttonClick = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FPS()
    {
        SceneManager.LoadScene(1);
    }
    public void mouseAction()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void playAudio()
    {
        buttonClick.Play();
    }
}
