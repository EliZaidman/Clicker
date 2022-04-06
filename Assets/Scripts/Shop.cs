using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _strudelsText;

    [SerializeField]
    private int _playerStrudels;

    void Start()
    {
        
    }

    void Update()
    {
        _strudelsText.text = _playerStrudels.ToString();
    }

    public GameObject Buy(GameObject gO)
    {
        switch (gO.name)
        {
            case "Buy 10":
                if (_playerStrudels >= 10)
                {
                    _playerStrudels -= 10;
                    print($"{_playerStrudels} - 10");
                }
                else
                    print("Insufficient Strudels");
                break;

            case "Buy 200":
                if (_playerStrudels >= 200)
                {
                    _playerStrudels -= 200;
                    print($"{_playerStrudels} - 200");
                }
                else
                    print("Insufficient Strudels");
                break;

            case "Buy 3000":
                if (_playerStrudels >= 3000)
                {
                    _playerStrudels -= 3000;
                    print($"{_playerStrudels} - 3000");
                }
                else
                    print("Insufficient Strudels");
                break;

            case "Buy 40000":
                if (_playerStrudels >= 40000)
                {
                    _playerStrudels -= 40000;
                    print($"{_playerStrudels} - 40000");
                }
                else
                    print("Insufficient Strudels");
                break;

            default:
                break;
        }

        return gO;
    }

    public void AddCurrency()
    {
        _playerStrudels += 20000;
        print($"{_playerStrudels} + 20000");
    }
}
