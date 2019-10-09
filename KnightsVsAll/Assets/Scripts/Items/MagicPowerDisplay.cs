using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicPowerDisplay : MonoBehaviour
{
    [SerializeField] int magicPower = 200;
    [SerializeField] int magicTimeDelay = 3;
    int OTmagicAdd = 25;
    Text magicPowerText;
    bool canAdd = true;

    private void Start()
    {
        magicPowerText = GetComponent<Text>();
        displayUpdate();
    }

    private void Update()
    {
        ifZeroMagic();
    }

    private void displayUpdate()
    {
        magicPowerText.text = magicPower.ToString();
    }

    public void ifZeroMagic()
    {

        if (magicPower > 0 && magicPower <= 150)
        {
            if (canAdd)
            {
                StartCoroutine(addMagicDelay());
            }
        }
    }

    IEnumerator addMagicDelay()
    {
        canAdd = false;
        //yield return new WaitForSeconds(magicTimeDelay);
        Debug.Log("canAdd SHOULD be active");
        yield return new WaitForSeconds(magicTimeDelay);
        magicPower += OTmagicAdd;
        displayUpdate();
        canAdd = true;
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