using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choque : MonoBehaviour
{
   
    private GameObject canvasS;
    // Start is called before the first frame update

    private void Start()
    {
       
        canvasS = GameObject.FindWithTag("CanvasS");
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.GetComponent<Jugador>() != null)
        {
           
            Destroy(collision.gameObject);
            GameOver();
           

        }


    }

    private void GameOver()
    {
         canvasS.SetActive(false);
        
    }
}
