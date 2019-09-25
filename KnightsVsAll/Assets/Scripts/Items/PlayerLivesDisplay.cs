using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesDisplay : MonoBehaviour
{
    [SerializeField]
    float playerLives = 1;
    Text playerLivesText;

    private void Start()
    {
        lvlModification();
        playerLivesText = GetComponent<Text>();
        Debug.Log("DIFFICULTY LEVEL: " +PlayerPrefsController.GetDifficulty() + " PLAYER LIVES: " +playerLives);
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

    public void lvlModification()
    {
        if (PlayerPrefsController.GetDifficulty() <= 0)
        {
            Debug.Log("DIFFICULTY LEVEL: " + PlayerPrefsController.GetDifficulty() + " PLAYER LIVES: " + playerLives);
        }

        if (PlayerPrefsController.GetDifficulty() >= 0.2 && PlayerPrefsController.GetDifficulty() <= 1)
        {
            playerLives = 100;
            Debug.Log("DIFFICULTY LEVEL: " + PlayerPrefsController.GetDifficulty() + " PLAYER LIVES: " + playerLives);
        }
        else if (PlayerPrefsController.GetDifficulty() >= 2)
        {
            playerLives = 50;
            Debug.Log("DIFFICULTY LEVEL: " + PlayerPrefsController.GetDifficulty() + " PLAYER LIVES: " + playerLives);
        }
    }

}//playerLives

