using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GameControll : MonoBehaviour
{
    public static int Coin = 0;
    public string CoinString = "Monedas: ";

    public Text TextCoin;
    public static GameControll Gamecontroll;

    void Awake()
    {
        Gamecontroll = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextCoin != null)
        {
            TextCoin.text = CoinString + "" + (Coin);
        }
    }
}
