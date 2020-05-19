using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTerreno : MonoBehaviour
{


    [SerializeField] private int mindistanciaDesdeJugador;
    [SerializeField] private List<TerrainData> infoTerreno = new List<TerrainData>();
    [SerializeField] private int LimiteTerreno;
    [SerializeField] private Transform guardarTerreno;

    public Vector3 pos;
    private List<GameObject> TerrenosActuales = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(0, 0, 0);
        mindistanciaDesdeJugador = 15;
        
        for(int i =0; i< LimiteTerreno; i++)
        {
            GenerarT(true, new Vector3(0,0,0));

        }
        LimiteTerreno = TerrenosActuales.Count;
        
    }

    // Update is called once per frame


    public void GenerarT(bool inicia , Vector3 posJugador)
    {
        if (pos.x - posJugador.x < mindistanciaDesdeJugador) 
        {
            int queTerreno = Random.Range(0, infoTerreno.Count);
            int terrenoEnCrecimiento = Random.Range(1, infoTerreno[queTerreno].maxEnFila);

            for (int i = 0; i < terrenoEnCrecimiento; i++)
            {
                GameObject terreno = Instantiate(infoTerreno[queTerreno].terreno, pos, Quaternion.identity, guardarTerreno);
                TerrenosActuales.Add(terreno);
                if (!inicia)
                {
                    if (TerrenosActuales.Count > LimiteTerreno)
                    {
                        Destroy(TerrenosActuales[0]);
                        TerrenosActuales.RemoveAt(0);
                    }
                }

                pos.x++;

            }
        }    
    }
}
