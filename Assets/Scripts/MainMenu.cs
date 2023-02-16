using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string LevelToLoad;
    public void TestScene()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Sector7GBombing()
    {
        SceneManager.LoadScene("Sector7GBombing");
    }
    public void ProtectTheKaaba()
    {
        SceneManager.LoadScene("ProtectTheKaaba");
    }
}
