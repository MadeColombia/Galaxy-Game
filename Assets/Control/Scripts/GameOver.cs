using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject canvas1;
    private GameObject canvas2;
    
    public Gamecontroller JOP;
    // public GameObject jugador;
    // string Menu;
    private void Start()
    {

        canvas2 = GameObject.FindWithTag("CanvasS");
        
        JOP = GetComponent<Gamecontroller>();

    }
    public void Update()
    {
        bool A = canvas2.activeSelf;
        bool R = false;
        if (A == R)    //canvas2.activeSelf.Equals(false)
        {
            
            
            
            canvas1.SetActive(true);

        }
        if (canvas1.activeSelf)
        {
            JOP.Creartxt();
            Debug.Log("Se envio");
        }

    }


    public void AbrirCanvas()
    {
       

    }
    public void Restart()
    {
       

        SceneManager.LoadScene("unityProject");
        Gamecontroller.coins = 0;
       
    }

    public void QuitToMain()
    {

        SceneManager.LoadScene("menu"); 
    }

}
