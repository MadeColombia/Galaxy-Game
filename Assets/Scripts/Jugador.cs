using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    [SerializeField] private GeneradorTerreno generadorTerreno;
    [SerializeField] private Text scoreText;
    private Animator animador;
    private bool saltando;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        animador = GetComponent<Animator>();
    }

    // Update is called once per frame
    //private void FixedUpdate()
    //{

        
    //}
    void Update()
    {
        scoreText.text = "Score:" + score;
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
            transform.rotation = Quaternion.AngleAxis(90, new Vector3(0, 1, 0));
            score++;
        }

        else if (Input.GetKeyDown(KeyCode.A) && !saltando) 
        {
            MoverPersonaje(new Vector3(0, 0, 1));
            transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 1, 0));
        }

        else if (Input.GetKeyDown(KeyCode.D) && !saltando)
        {
            MoverPersonaje(new Vector3(0, 0, -1));
            transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
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
