using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSide : MonoBehaviour
{
    public GameObject chooseCanvas;
    private string playerChoiseSide;
    public void ChooseSideO()
    {
        playerChoiseSide = "O";
        chooseCanvas.SetActive(false);
    }

    public void ChooseSideX()
    {
        playerChoiseSide = "X";
        chooseCanvas.SetActive(false);
    }

}
