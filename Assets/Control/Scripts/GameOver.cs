using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject canvas1;
    private GameObject canvas2;
    public int Jo;
    static public int NUMERO = 1;
    public Gamecontroller JOP;
    // public GameObject jugador;
    // string Menu;
    public static bool Cancel;
    private void Start()
    {

        canvas2 = GameObject.FindGameObjectWithTag("CanvasS");
        Jo = 0;
        JOP = GetComponent<Gamecontroller>();
        // NUMERO = 1;
        Cancel = true;
    }
    public void Update()
    {
        Debug.Log("Primer if" + Cancel.ToString());
        if (Cancel == true)
        {
            bool A = canvas2.activeInHierarchy;
            bool R = false;
            if (A == R )    //canvas2.activeSelf.Equals(false)
            {



                canvas1.SetActive(true);
                Jo++;
                Cancel = false;
                Debug.Log("Final if" + Cancel.ToString());
            }

        }
        else
        {
            Debug.Log("nada pasa");
        }
           
        if (Jo == 1)
        {

            JOP.Creartxt();
           
            Debug.Log("Se envio");
            
        }

    }


    public void Restart()
    {
       

        SceneManager.LoadScene("unityProject");
        Gamecontroller.coins = 0;
        Jo = 0;
        NUMERO++;
        Jugador.score = 0;
        Cancel = true;
    }

    public void QuitToMain()
    {

        SceneManager.LoadScene("menu");
        Cancel = true;
    }

}
