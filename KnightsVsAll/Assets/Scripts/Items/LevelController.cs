using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numofAttackers = 0;
    bool timerEnded = false;
    [SerializeField] GameObject completedLvl;
    [SerializeField] float waitToLoad = 4f;
    [SerializeField] GameObject failedLvl;

    private void Start()
    {
        completedLvl.SetActive(false);
        failedLvl.SetActive(false);
    }

    public void enemyiesSpawned()
    {
        numofAttackers++;
    }

    public void enemiesKilled()
    {
        numofAttackers--;

        if (numofAttackers <=0 && timerEnded)
        {
            StartCoroutine(gameWon());
            //Debug.Log("Game has Ended");
        }
    }

    IEnumerator gameWon()
    {
        completedLvl.SetActive(true);
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoad>().LoadNextScene();
    }

    public void gameFailedCondition()
    { 
        failedLvl.SetActive(true);
        Time.timeScale = 0;
    }

    public void lvlFinished()
    {
        timerEnded = true;
        stopSpawners();
    }

    public void stopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.stopSpawning();
        }
    }

}//levelController
