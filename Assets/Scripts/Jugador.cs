using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField]private GeneradorTerreno generadorTerreno;

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
            float diferenciaZ = 0;
            if (transform.position.z % 1 == 0)
            {
                diferenciaZ = Mathf.RoundToInt(transform.position.z) - transform.position.z;
            }
            Vector3 diferencia = new Vector3(1, 0, diferenciaZ);
            MoverPersonaje (diferencia);
        }

        else if (Input.GetKeyDown(KeyCode.A) && !saltando) 
        {
            MoverPersonaje(new Vector3(0, 0, 1));
        }

        else if (Input.GetKeyDown(KeyCode.D) && !saltando)
        {
            MoverPersonaje(new Vector3(0, 0, -1));
        }
    }
    private void MoverPersonaje(Vector3 diferencia) 
    {
        animador.SetTrigger("salto");
        saltando = true;
        transform.position = (transform.position + diferencia);
        generadorTerreno.GenerarT(false,transform.position);
    }

    public void finSalto()
    {
        saltando = false;
    }
}
