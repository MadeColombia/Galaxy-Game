using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptmoneda : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;
    public AudioClip clip;
    public int Puntaje = 1;

    
    
    
    
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("moneda"))
        {
            
            Destroy(col.gameObject);
            source.PlayOneShot(clip);
            //Gamecontroller.coins += Puntaje;



            Gamecontroller.coins += Puntaje;
           
        }
            
            

        }
        
            
        
    
  
    void Start()
    {
        //textMonedas.text = "Coins: ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
