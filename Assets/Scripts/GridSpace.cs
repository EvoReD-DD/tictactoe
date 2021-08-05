using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button buttonSpace;
    public Text buttonText;
    
    private GameController gameController;

   
    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

    public void SetSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        buttonSpace.interactable = false;
        gameController.EndTurn();
    }
}
