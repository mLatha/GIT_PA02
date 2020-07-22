using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState { GameOver, GameStart, GameIdle };
    public static GameState CurrentState = GameState.GameIdle;

    public static int Lives = 3;
    public static int Score = 0;

    void Start()
    {
        HUD.HUDManager.LoadLives();
        HUD.HUDManager.LoadScore();
        Time.timeScale = 0;
        CurrentState = GameState.GameIdle;
    }

    void Update()
    {
        Lives.ToString();
        if (CurrentState == GameState.GameIdle && Input.GetKeyDown(KeyCode.Return))
        {
            CurrentState = GameState.GameStart;
            Time.timeScale = 1;
            HUD.HUDManager.DismissMessage();
        }

        else if (CurrentState == GameState.GameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }

        if (Lives == 0)
            //if player runs out of lives they will be sent to gameover scene
            SceneManager.LoadScene("GameOver");
    } 
}

