using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class IdleClicker : MonoBehaviour
{

    [SerializeField]
    public  TextMeshProUGUI _idleClickerText;
    public TextMeshProUGUI _shdrudalCostPerSecText;
    public TextMeshProUGUI _shdrudelText;


    public double shdrudel;


    public double shtrudalpersecond;
    public int idleClickerUpgrade;
    public double idleClickerUpgradeCost;

    void Start()
    {
        idleClickerUpgradeCost = 25;
    }

    // Update is called once per frame
    void Update()
    {
        shtrudalpersecond = idleClickerUpgrade;

        _shdrudelText.text = "Shtrudel: " + shdrudel.ToString("F0");

        _shdrudalCostPerSecText.text = shtrudalpersecond.ToString("F0") + "Shtrudel/s";

        _idleClickerText.text = "Idle Clicker Upgrade 1\nCost: " + idleClickerUpgradeCost + "shdrudels\nPower: +1 shdrudel/s\nLevel: " + idleClickerUpgrade;

        shdrudel += shtrudalpersecond * Time.deltaTime;

    }


    public void BuyIdle()
    {
        if (shdrudel >= idleClickerUpgradeCost)
        {
            idleClickerUpgrade++;
            shdrudel -= idleClickerUpgradeCost;
            idleClickerUpgradeCost *= 1.07;
        }
        

    }
}
