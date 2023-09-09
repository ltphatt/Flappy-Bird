using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPauseGame = false;
    [SerializeField] GameObject pauseMenu;

    FlyBehavior player;

    void Start()
    {
        player = FindObjectOfType<FlyBehavior>();
    }

    void Update()
    {
        if (player.PlayerIsAlive())
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPauseGame)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPauseGame = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPauseGame = true;
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
