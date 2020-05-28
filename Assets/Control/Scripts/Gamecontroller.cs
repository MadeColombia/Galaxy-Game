using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class Gamecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coins = 0;
    private int i = 1;
    public string coinsString = "Coins";
   // public string Texto1;
    //public string Texto2;
    
    public List<string> Texto2 = new List<string>();
    public string Texto3;
    public Text TextCoins;
    public static Gamecontroller gamecontroller;
    public GameObject canvas;
    private bool creado;
    

    
    void Start()
    {

        creado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TextCoins != null)
        {
            TextCoins.text = coinsString + coins.ToString();
            Texto3 = "Coins totales =" + ""+ coins.ToString();
        }

        if (canvas.activeSelf == false && creado == false)
        {
            creado = true;
            Creartxt();
            //Texto1.Push(jugador.scoreText.text);
            Texto2.Add(Jugador.score+"");
            //Debug.Log(Jugador.score + "");

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
     
            string contenido = "Intento #" + i + ":" + "\n" + "Score:" + Jugador.score + "\n" + "High Score:" + PlayerPrefs.GetInt("PuntajeRecord", Jugador.score) + "\n" + "" + Texto3 + "\n";
            //Poner el texto 
            File.AppendAllText(path, contenido);
            i++;
       
        

    }

    
    

}
        
    
