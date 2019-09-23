using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender KnightsPrefab;


    private void Start()
    {
        buttonCost();
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();

        foreach (DefenderButton charButton in buttons)
        {
            charButton.GetComponent<SpriteRenderer>().color = new Color32(41,41,41,255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;

        FindObjectOfType<DefenderSpawner>().SelectedDefender(KnightsPrefab);
        //Debug.Log("Character Selected: " + KnightsPrefab.name);
    }

    private void buttonCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if (!costText)
        {
            Debug.LogError(name + " Has no cost!");
        }
        else{
            costText.text = KnightsPrefab.getmagicCost().ToString();
        }
    }

}//button
