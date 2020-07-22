﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD HUDManager;
    [SerializeField] private Text Txt_Score = null;
    [SerializeField] private Image Image_Lives = null;
    [SerializeField] private Text Txt_Message = null;
 
    void Start()
    {
        HUDManager = this;
    }

    public void UpdateScore()
    {
        GameManager.Score += 1;
        Txt_Score.text = "SCORE : " + GameManager.Score;
    }
    
    public static void SaveScore()
    {
        PlayerPrefs.SetFloat("Score", GameManager.Score);
    }

    public void LoadScore()
    {
        GameManager.Score.ToString();
        Txt_Score.text = "SCORE : " + GameManager.Score;
        PlayerPrefs.GetFloat("Score");
    }

    //updates the number of hearts for lives
    public void UpdateLives()
    {
        GameManager.Lives -= 1;
        Image_Lives.rectTransform.sizeDelta = new Vector2(GameManager.Lives * 50, 30);
        PlayerPrefs.SetFloat("Lives", GameManager.Lives);
    }

    public void LoadLives()
    {
        GameManager.Lives.ToString();
        Image_Lives.rectTransform.sizeDelta = new Vector2(GameManager.Lives * 50, 30);
        PlayerPrefs.GetFloat("Lives");
    }

    //Minus 1 life
    public void GameOver()
    {
        UpdateLives();
        Time.timeScale = 0;
        GameManager.CurrentState = GameManager.GameState.GameOver;
        Txt_Message.color = Color.red;
        Txt_Message.text = "GAME OVER! \n PRESS ENTER TO RESTART GAME.";
    }

    public void DismissMessage()
    {
        Txt_Message.text = "";
    }
}
