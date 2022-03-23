using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{

    public int _money;
    public TextMeshProUGUI _moneyText;

    #region ShopVar

    public int shop1prize;
    public TextMeshProUGUI shop1text;

    public int shop2prize;
    public TextMeshProUGUI shop2text;


    #endregion

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moneyText.text = _money.ToString();

        #region ShopArea

        shop1text.text = "Shop Tier 1 " + shop1prize + " $/@";
        shop2text.text = "Shop Tier 1 " + shop2prize + " $/@";

        #endregion
    }

    public void RiseMoney()
    {
        _money++;
    }

    public void Shop1()
    {

    }

    public void Shop2()
    {

    }
}
