using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coins = 0;
    public string coinsString = "Coins";

    public Text TextCoins;
    public static Gamecontroller gamecontroller;

    private void Awake()
    {
        gamecontroller = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TextCoins != null)
        {
            TextCoins.text = coinsString + coins.ToString();
        }
    }

    public void Restart()
    {
        
        TextCoins.text = coinsString + coins.ToString("0");
    }

}
        
    
