using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Jugador>() != null)
        {
            Destroy(collision.gameObject);
            
        }


    }
}
