using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{

    public int money;
    public TextMeshProUGUI moneyText;

    // Update is called once per frame
    private void Update()
    {
        moneyText.text = money.ToString();
    }

    public void RiseMoney()
    {
        money += 2;
        Debug.Log("AddedMoney" + money);
        moneyText.text = money.ToString();
    }
}
