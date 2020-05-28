using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choque : MonoBehaviour
{
   
    private GameObject canvasS;
    //public bool SeMurio;
    public AudioSource source;
    public AudioClip clip;
    
   
    // Start is called before the first frame update

    public void Start()
    {

        canvasS = GameObject.FindWithTag("CanvasS");
       
    }

    private void Update()
    {
        
    }

   

    public void OnCollisionEnter(Collision collision)
    {
        

        if (collision.collider.GetComponent<Jugador>() != null)
        {
            
            Destroy(collision.gameObject);
            source.PlayOneShot(clip);
            GameOver();
            

        }


    }

    public void GameOver()
    {
         canvasS.SetActive(false);
        
       

    }
}
