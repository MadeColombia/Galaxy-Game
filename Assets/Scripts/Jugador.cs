using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    private Animator animador;
    private bool saltando;
    // Start is called before the first frame update
    void Start()
    {
        animador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !saltando)
        {
            animador.SetTrigger("salto");
            saltando = true;
            Debug.Log(transform.position);
            if(transform.position.z % 1 == 1)
            {
                transform.Translate(new Vector3(1, 0, 0));
                Debug.Log("En area");
            }
               

            
        }
    }

    public void finSalto()
    {
        saltando = false;
    }
}
