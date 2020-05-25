using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject jugador;
    // string Menu;
    private void Start()
    {
        canvas1.CompareTag("CanvasO");
        canvas2.CompareTag("CanvasS");
        jugador.CompareTag("Player");
    }
    public void Update()
    {
        if (jugador = null)
        {
            canvas1.SetActive(true);
            canvas2.SetActive(false);
        }
    }
    public void Restart()
    {
        
        
    }

    public void QuitToMain()
    {
       
        //Application.LoadLevel(Menu);
    }

}
