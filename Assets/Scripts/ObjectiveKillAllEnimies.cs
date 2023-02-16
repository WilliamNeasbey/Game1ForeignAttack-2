using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveKillAllEnimies : MonoBehaviour
{
    public GameObject[] Enemy;
    public GameObject WinScreen;
    public string LevelToLoad;

    private void Start()
    {
        //WinScreen.SetActive(false);
    }

    public void Update()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");

        if (Enemy.Length == 0)
        {
            Application.LoadLevel(LevelToLoad);


        }
    }

}
