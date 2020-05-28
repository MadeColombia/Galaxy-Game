using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class Jugador : MonoBehaviour
{
    [SerializeField] public GeneradorTerreno generadorTerreno;
    //private GameObject m = new GameObject();

    // private int j = 1;
    public Gamecontroller T1;
    [SerializeField] public agregarscore Puente;

    [SerializeField] public Text scoreText;
    [SerializeField] public Text recordScoreText;
    private Animator animador;
    private bool saltando;
    public static int score;
    public GameObject jugador;
    static public string record;



    // Start is called before the first frame update
    void Start()
    {
        animador = GetComponent<Animator>();
        recordScoreText.text = PlayerPrefs.GetInt("PuntajeRecord", 0).ToString();
        T1 = GetComponent<Gamecontroller>();
        


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
            string puntaje = "Puntaje =" + "" + score.ToString();
            
            //T1.Texto1.Add(puntaje);
            //T1.Texto1.Push(puntaje);
            

            //PlayerPrefs.SetString("tx",tx);
            
            if (score > PlayerPrefs.GetInt("PuntajeRecord", 0))
            {
                PlayerPrefs.SetInt("PuntajeRecord", score);
                recordScoreText.text = score.ToString();
                 record = "Puntaje Record =" + "" + PlayerPrefs.GetInt("PuntajeRecord",score);
                //T1.Texto2.Add(record);
                

            }



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
