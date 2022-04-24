using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    PauseAction pauseAction;
    public static bool paused = false;
    [SerializeField] GameObject pauseMenu;

    private void Awake()
    {
        pauseAction = new PauseAction();
    }
    private void OnEnable()
    {
        pauseAction.Enable();
    }
    private void OnDisable()
    {
        pauseAction.Disable();
    }
    private void Start()
    {
        pauseAction.Pause.PauseGame.performed += _ => DeterminePause();
    }
    private void DeterminePause()
    {
        if (paused)
        {
            ResumeGame();
        }
        else
            PauseGame();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        paused = true;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        paused = false;
        pauseMenu.SetActive(false);
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }
}
