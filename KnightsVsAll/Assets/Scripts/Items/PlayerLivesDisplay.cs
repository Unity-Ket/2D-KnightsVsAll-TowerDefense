using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesDisplay : MonoBehaviour
{
    [SerializeField]
    float playerLives = 200, midLvlLives =100, hardLvlLives = 50;
    Text playerLivesText, midLvlLivesText, hardLvlLivesText;

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
        midLvlLivesText.text = midLvlLives.ToString();
        hardLvlLivesText.text = hardLvlLives.ToString();
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
        if (PlayerPrefsController.GetDifficulty() > 0 && PlayerPrefsController.GetDifficulty() <= 1)
        {
            playerLives = midLvlLives;
            //midLvlLivesText.text = midLvlLives.ToString();
            if (midLvlLives <= 0)
            {
                FindObjectOfType<LevelController>().gameFailedCondition();
            }
            Debug.Log("DIFFICULTY LEVEL: " + PlayerPrefsController.GetDifficulty() + " PLAYER LIVES: " + playerLives);
        }
        else if (PlayerPrefsController.GetDifficulty() > 1 && PlayerPrefsController.GetDifficulty() <= 2)
        {
            playerLives = hardLvlLives;
            //hardLvlLivesText.text = hardLvlLives.ToString();
            if (hardLvlLives <= 0)
            {
                FindObjectOfType<LevelController>().gameFailedCondition();
            }
            Debug.Log("DIFFICULTY LEVEL: " + PlayerPrefsController.GetDifficulty() + " PLAYER LIVES: " + playerLives);
        }
    }

}//playerLives

