using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class menu : MonoBehaviour
{

    public void startgame()
    {
        Debug.Log("start");
        SceneManager.LoadScene("Space Invaders");
    }
    public void exitgame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
