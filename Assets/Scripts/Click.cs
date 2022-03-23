using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{

    public int _money;
    public TextMeshProUGUI _moneyText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moneyText.text = _money.ToString();
    }

    public void RiseMoney()
    {
        _money++;
    }
}
