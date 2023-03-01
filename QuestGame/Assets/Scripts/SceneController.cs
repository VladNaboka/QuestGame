using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] string nameStartScene;
    [SerializeField] string nameMenuScene;

    public void gameScene()
    {
        SceneManager.LoadScene(nameStartScene);
    }
    public void MenuScene()
    {
        SceneManager.LoadScene(nameMenuScene);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
