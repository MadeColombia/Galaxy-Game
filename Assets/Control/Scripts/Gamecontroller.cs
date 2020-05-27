using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coins = 0;
    private int i = 1;
    public string coinsString = "Coins";
    //public string Texto1;
    //public string Texto2;
    public Stack<string> Texto1 = new Stack<string>();
    public List<string> Texto2 = new List<string>();
    public string Texto3;
    public Text TextCoins;
    public static Gamecontroller gamecontroller;

    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (TextCoins != null)
        {
            TextCoins.text = coinsString + coins.ToString();
            Texto3 = "Coins totales =" + ""+ coins.ToString();
        }
    }

    public void Restart()
    {
        
        TextCoins.text = coinsString + coins.ToString();
    }

    public void Creartxt()
    {


        //Path del texto
        string path = Application.dataPath + "/Datos de Juego.txt";

        //Crear file si no existe
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Datos de Juego \n\n");
            //j++;

        }

        //Contenido del file 
        string contenido = "Intento #" + i + ":" + "\n" + Texto1.ToString() + "\n" + Texto2.Contains(ToString()) +"\n"+ Texto3 + "\n\n";
        // contenido = "Intento #" + i + "\n" + ":" + "" + tx + "\n" + tx2 + "\n" + Puente.tx3 + "\n\n";
        i++;
        //Poner el texto 
        File.AppendAllText(path, contenido);

    }

}
        
    
