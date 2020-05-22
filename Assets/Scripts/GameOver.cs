using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject Panel;
    public GameObject jugador;
    public string Menu;
    

    public void Restart()
    {
        
        
    }

    public void QuitToMain()
    {
        Application.LoadLevel(Menu);
    }

}
