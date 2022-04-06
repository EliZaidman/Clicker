using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class IdleClicker : MonoBehaviour
{

    [SerializeField]
    public  TextMeshProUGUI _idleClickerText;
    public TextMeshProUGUI _shdrudalPassiveCostText;
    public TextMeshProUGUI _shdrudelText;


    public double shdrudel;


    public double shtrudalPassive;
    public int passiveUpgrade;
    public double passiveUpgradeCost;

    void Start()
    {
        passiveUpgradeCost = 25;
    }

    // Update is called once per frame
    void Update()
    {
        shtrudalPassive = passiveUpgrade;

        _shdrudelText.text = "Shtrudel: " + shdrudel.ToString("F0");

        _shdrudalPassiveCostText.text = shtrudalPassive.ToString("F0") + "Shtrudel/s";

        _idleClickerText.text = "Passive Upgrade numer 1\nCost: " + passiveUpgradeCost + "shdrudels\nPower: +1 shdrudel/s\nLevel: " + passiveUpgrade;

        shdrudel += shtrudalPassive * Time.deltaTime;

    }


    public void BuyIdle()
    {
        if (shdrudel >= passiveUpgradeCost)
        {
            passiveUpgrade++;
            shdrudel -= passiveUpgradeCost;
            passiveUpgradeCost *= 1.05;
        }
        

    }
}
