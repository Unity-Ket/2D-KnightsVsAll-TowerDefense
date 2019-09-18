using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesDisplay : MonoBehaviour
{
    [SerializeField] int playerLives = 1;
    Text playerLivesText;

    private void Start()
    {
        playerLivesText = GetComponent<Text>();
        displayUpdate();
    }

    private void displayUpdate()
    {
        playerLivesText.text = playerLives.ToString();
    }

    public void takeLives(int PlayerdmgAmount)
    {
            playerLives -= PlayerdmgAmount;
            displayUpdate();

        if (playerLives <= 0)
        {
            FindObjectOfType<LevelController>().gameFailedCondition();
        }
    }

}//playerLives

