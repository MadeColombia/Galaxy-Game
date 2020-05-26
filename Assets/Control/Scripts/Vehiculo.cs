using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    private float velocidad;
    


    private void Start()
    {
        transform.Rotate(0, -90, 0);
        velocidad = Random.Range(2,5);
    }
    private void Update()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            Object.Destroy(gameObject, 15f);
        
       
    }

   
}
