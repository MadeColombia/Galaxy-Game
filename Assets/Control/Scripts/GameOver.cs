using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject canvas1;
    private GameObject canvas2;
   // public GameObject jugador;
    // string Menu;
    private void Start()
    {

        canvas2 = GameObject.FindWithTag("CanvasS");

    }
    public void Update()
    {
        if (canvas2.activeSelf.Equals(false))
        {
            canvas1.SetActive(true);
        }
    }
    public void Restart()
    {
       

        SceneManager.LoadScene("unityProject");
    }

    public void QuitToMain()
    {

        SceneManager.LoadScene("menu"); 
    }

}
