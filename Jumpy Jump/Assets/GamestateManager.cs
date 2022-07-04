using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GamestateManager : MonoBehaviour
{
    public Gamestate gamestate;
    public GameObject GameOverCanvas;
    public GameObject StartCanvas;



   public enum Gamestate
    {
        Start,
        Current,
        GameOver
    }

    void Start()
    {
        StartGame();
        
    }

   public void Gameover()
    {
        gamestate = Gamestate.GameOver;
        GameOverCanvas.SetActive(true);
        StartCanvas.SetActive(false);
        Time.timeScale = 0;

    }

    public void StartGame()
    {
        gamestate = Gamestate.Start;
        GameOverCanvas.SetActive(false);
        StartCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Current()
    {
        Time.timeScale = 1;
        StartCanvas.SetActive(false);
    }

    void Update()
    {


    }
}
