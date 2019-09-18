using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "Master Volunme";
    const string DIFFICULTY_SETTINGS = "Game Difficulty";

    const float MIN_VOLUME = 0f, MAX_VOLUME = 2f;


    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            Debug.Log("Master Volume Set to: " + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else {
            Debug.LogError("Master volume is out of Range");
        }
        
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

}//class
