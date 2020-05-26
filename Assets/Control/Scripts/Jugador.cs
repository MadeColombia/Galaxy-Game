using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Jugador : MonoBehaviour
{
    [SerializeField] public GeneradorTerreno generadorTerreno;
    //private GameObject m = new GameObject();
    private int i = 1;
    private int j = 1;
    private string tx;
    private string tx2;
    public agregarscore Puente;
    public Choque C;
    [SerializeField] public Text scoreText;
    [SerializeField] public Text recordScoreText;
    private Animator animador;
    private bool saltando;
    private int score;

  

    // Start is called before the first frame update
    void Start()
    {
        animador = GetComponent<Animator>();
        recordScoreText.text = PlayerPrefs.GetInt("PuntajeRecord", 0).ToString();
        

    }

    // Update is called once per frame
    //private void FixedUpdate()
    //{


    //}
    private void Update()
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
            MoverPersonaje(diferencia);
            transform.rotation = Quaternion.AngleAxis(90, new Vector3(0, 1, 0));
            score++;
            tx = "Puntaje =" + "" + score.ToString();
            if (score > PlayerPrefs.GetInt("PuntajeRecord", 0))
            {
                PlayerPrefs.SetInt("PuntajeRecord", score);
                recordScoreText.text = score.ToString();
                tx2 = "Puntaje Record =" + "" + PlayerPrefs.GetInt("PuntajeRecord", 0);
                

            }
            if (C.SeMurio == true)
            {
                Creartxt();
                C.SeMurio = false;


            }

            //Creartxt();

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
        else if (Input.GetKeyDown(KeyCode.S) && !saltando)
        {
            MoverPersonaje(new Vector3(-1, 0, 0));
            transform.rotation = Quaternion.AngleAxis(-90, new Vector3(0, 1, 0));
            score--;
        }


        


    }

    
    public void MoverPersonaje(Vector3 diferencia)
    {
        animador.SetTrigger("salto");
        saltando = true;
        transform.position = (transform.position + diferencia);
        generadorTerreno.GenerarT(false, transform.position);


    }

    public void borrarDatosPuntaje()
    {
        PlayerPrefs.DeleteKey("PuntajeRecord");
        recordScoreText.text = "0";
    }

    public void finSalto()
    {
        saltando = false;
        
    }


     public void Creartxt()
    {
       

            //Path del texto
            string path = Application.dataPath + "/Datos de Juego"+j+".txt";

            //Crear file si no existe
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Datos de Juego \n\n");
            //j++;
            
            }

            //Contenido del file 
            string contenido = "Intento #" + i + ":" +"\n" + "" + tx + "\n" + tx2 + "\n\n";
        // contenido = "Intento #" + i + "\n" + ":" + "" + tx + "\n" + tx2 + "\n" + Puente.tx3 + "\n\n";
           i++;
            //Poner el texto 
            File.AppendAllText(path, contenido);
        
    }







    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.GetComponent<Tabla>() != null)
        {
            
            

            if (collision.collider.GetComponent<Tabla>().isTab)
            {


             
                transform.SetParent(collision.collider.transform, true);
                



            }
        }
        else
        {
            transform.parent = null;
            
        }
    }

}
