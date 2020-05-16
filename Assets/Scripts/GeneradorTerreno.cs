using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTerreno : MonoBehaviour
{


    private Vector3 pos = new Vector3(0, 0, 0);
    private List<GameObject> TerrenosActuales = new List<GameObject>();
    [SerializeField] private List<GameObject> terrenos = new List<GameObject>();
    [SerializeField] private int LimiteTerreno;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i< LimiteTerreno; i++)
        {
            GenerarT();

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GenerarT();
        }
    }

    private void GenerarT()
    {
        GameObject terreno =  Instantiate(terrenos[Random.Range(0,terrenos.Count)],pos,Quaternion.identity);
        TerrenosActuales.Add(terreno);
        if(TerrenosActuales.Count > LimiteTerreno)
        {
            Destroy(TerrenosActuales[0]);
            TerrenosActuales.RemoveAt(0);
        }
        pos.x++;
    }
}
