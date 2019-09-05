using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int magicCost = 100;


    public void addMagicOT(int amount)
    {
        //check animation event for magicOT amount
        FindObjectOfType<MagicPowerDisplay>().addMagic(amount);
    }

    public int getmagicCost()
    {
        return magicCost;
    }

}//Defender
