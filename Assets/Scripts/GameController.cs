using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text[] buttonSpaceList;
    private string playerChoiseSide;
    public GameObject restart;
    public GameObject chooseCanvass;

    void Awake()
    {
       SetGameControllerReferenceOnButtons();
        
    }
    void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonSpaceList.Length; i++)
        {
            buttonSpaceList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }

    public string GetPlayerSide()
    {
        return playerChoiseSide;
    }

    public void EndTurn()
    {
        if (buttonSpaceList[0].text == playerChoiseSide && buttonSpaceList[1].text == playerChoiseSide && buttonSpaceList[2].text == playerChoiseSide)
        {
            GameOver();
        }
        if (buttonSpaceList[3].text == playerChoiseSide && buttonSpaceList[4].text == playerChoiseSide && buttonSpaceList[5].text == playerChoiseSide)
        {
            GameOver();
        }
        if (buttonSpaceList[6].text == playerChoiseSide && buttonSpaceList[7].text == playerChoiseSide && buttonSpaceList[8].text == playerChoiseSide)
        {
            GameOver();
        }
        if (buttonSpaceList[0].text == playerChoiseSide && buttonSpaceList[3].text == playerChoiseSide && buttonSpaceList[6].text == playerChoiseSide)
        {
            GameOver();
        }
        if (buttonSpaceList[1].text == playerChoiseSide && buttonSpaceList[4].text == playerChoiseSide && buttonSpaceList[7].text == playerChoiseSide)
        {
            GameOver();
        }
        if (buttonSpaceList[2].text == playerChoiseSide && buttonSpaceList[5].text == playerChoiseSide && buttonSpaceList[8].text == playerChoiseSide)
        {
            GameOver();
        }
        if (buttonSpaceList[0].text == playerChoiseSide && buttonSpaceList[4].text == playerChoiseSide && buttonSpaceList[8].text == playerChoiseSide)
        {
            GameOver();
        }
        if (buttonSpaceList[2].text == playerChoiseSide && buttonSpaceList[4].text == playerChoiseSide && buttonSpaceList[6].text == playerChoiseSide)
        {
            GameOver();
        }
       
        ChangeSides();
    }

    void ChangeSides()
    {
        playerChoiseSide = (playerChoiseSide == "X") ? "O" : "X"; // Note: Capital Letters for "X" and "O"
    }
    void GameOver()
    {
        for (int i = 0; i < buttonSpaceList.Length; i++)
        {
            buttonSpaceList[i].GetComponentInParent<Button>().interactable = false;
            restart.SetActive(true);
        }
    }
}
