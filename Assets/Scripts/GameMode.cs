using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    bool gameMode;
    bool playerChoise;
    string singlePlayer = "Single";
    string twoPlayers = "VS";
    string playerX = "X";
    string playerO = "O";
    public Toggle modeChange;
    public Toggle playerChange;

    
     void Start()
    {
        
    }

    public void ChangeMode()
    {
        if (modeChange.isOn)
        {
            modeChange.GetComponent<Text>().text = singlePlayer;
            gameMode = true;
            Debug.Log("single");
        }
        else {
            modeChange.GetComponent<Text>().text = twoPlayers;
            gameMode = false;
        }
    }
    public void PlayerChoose()
    {
        if (playerChange.isOn)
        {
            playerChange.GetComponent<Text>().text = playerX;
            playerChoise = true;

        }
        else
        {
            playerChange.GetComponent<Text>().text = playerO;
            playerChoise = false;
        }
    }
}
