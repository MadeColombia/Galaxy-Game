using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choque : MonoBehaviour
{
   
    private GameObject canvasS;
    public bool SeMurio;
    // Start is called before the first frame update

    private void Start()
    {

        canvasS = GameObject.FindWithTag("CanvasS");
        SeMurio = false;
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

        SeMurio = true;
    }
}
