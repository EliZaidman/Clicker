using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{

    public int money;
    public TextMeshProUGUI moneyText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString();
    }

    public void RiseMoney()
    {
        money++;
    }
}
