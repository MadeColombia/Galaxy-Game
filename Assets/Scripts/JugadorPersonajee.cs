using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorPersonajee : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadMovimiento,velocidadRotacion;
    //private Animator anim;
    public float x, y ;
    
    void Start()
    {
        velocidadMovimiento = 5.0f;
        velocidadRotacion = 100.0f;
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        //anim.SetFloat("VelX", x);
        //anim.SetFloat("VelY", y);
        
        
    }
}
