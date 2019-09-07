using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicPowerDisplay : MonoBehaviour
{
    [SerializeField] int magicPower = 200;
    //int OTmagicAdd = 5;
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

    //private void ifZeromagic()
    //{
    //    //TODO add magic OT if below 100
    //    if (magicPower <= 0 && magicPower <= 100)
    //    {
    //        magicPower += OTmagicAdd * Time.deltaTime;
    //        displayUpdate();
    //    }

    //}


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