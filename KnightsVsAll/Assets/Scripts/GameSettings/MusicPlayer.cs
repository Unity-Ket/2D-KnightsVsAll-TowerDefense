using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.volume = PlayerPrefsController.GetMasterVolume();

    }

    public void SetVolume(float volume)
    {
        music.volume = volume;
    }

}//Musicplayer class
