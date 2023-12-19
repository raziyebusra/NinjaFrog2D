using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;

    PauseAction action;
    public GameObject pauseMenu;

    private void Awake()
    {
        action = new PauseAction();
    }
    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void Start()
    {
        action.Pause.PauseGame.performed += _ => DeterminePause();
    }

    private void DeterminePause()
    {
        if (paused)
            Resume();
        else
            Pause();
    }


    public void Pause()
    {
        Time.timeScale = 0f;
        AudioListener.pause = true;
        paused = true;
        pauseMenu.SetActive(true);

    }
    public void Resume()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        paused = false;
        pauseMenu.SetActive(false);

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Resume();

    }
}
