using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int Moneda = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.tag == "Player")
        {
            GameControll.Coin += Moneda;
            Destroy(gameObject);
        }

    }
}
