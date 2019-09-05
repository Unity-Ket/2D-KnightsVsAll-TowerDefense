using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicPowerDisplay : MonoBehaviour
{
    [SerializeField] int magicPower = 200;
    Text magicPowerText;

    private void Start()
    {
        magicPowerText = GetComponent<Text>();
        displayUpdate();
    }

    private void displayUpdate()
    {
        magicPowerText.text = magicPower.ToString();
    }

    public bool enoughmagic(int amount)
    {
        return magicPower >= amount;
    }

    public void addMagic(int amount)
    {
        magicPower += amount;
        displayUpdate();
    }

    public void spendMagic(int amount)
    {
        if (magicPower >= amount)
        {
            magicPower -= amount;
            displayUpdate();
        }

    }

}//magicpower