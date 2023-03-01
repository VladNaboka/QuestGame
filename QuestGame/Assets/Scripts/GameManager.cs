using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public void PauseMenuOn()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void PauseMenuOff()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
