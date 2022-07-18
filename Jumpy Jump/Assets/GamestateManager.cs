using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GamestateManager : MonoBehaviour
{
    public Gamestate gamestate;
    public GameObject GameOverCanvas;
    public GameObject StartCanvas;
    public GameObject WinningCanvass;
    public GameObject NextButton;



   public enum Gamestate
    {
        Start,
        Current,
        GameOver,
        Win
    }

    void Start()
    {
        StartGame();
        WinningCanvass.SetActive(false);
    }

   public void Gameover()
    {
        gamestate = Gamestate.GameOver;
        GameOverCanvas.SetActive(true);
        StartCanvas.SetActive(false);
        WinningCanvass.SetActive(false);
        Time.timeScale = 0;


    }

    public void StartGame()
    {
        gamestate = Gamestate.Start;
        GameOverCanvas.SetActive(false);
        StartCanvas.SetActive(true);
        WinningCanvass.SetActive(false);
        NextButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void Current()
    {
        gamestate = Gamestate.Current;
        Time.timeScale = 1;
       StartCanvas.SetActive(false);
        //NextButton.SetActive(false);
        //WinningCanvass.SetActive(false);
    }
    
    public void Win()
    {
        gamestate = Gamestate.Win;
        WinningCanvass.SetActive(true);
        NextButton.SetActive(true);
        Time.timeScale = 1;

    }

    public void ButtonMoveScene (string level)
    {
        SceneManager.LoadScene(level);
    }
}
