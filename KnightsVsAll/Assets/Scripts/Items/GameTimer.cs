using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in SECONDS")]
    [SerializeField] float levelTimer = 10;
    bool triggeredlvlFinished = false;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (triggeredlvlFinished) { return; }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTimer;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTimer);

        if (timerFinished)
        {
            FindObjectOfType<LevelController>().lvlFinished();
            Debug.Log("Level Timer is Completed");
            triggeredlvlFinished = true;
        }
    }
}
