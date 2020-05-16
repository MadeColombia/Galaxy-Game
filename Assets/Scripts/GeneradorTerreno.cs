using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTerreno : MonoBehaviour
{


    private Vector3 pos = new Vector3(0, 0, 0);
    private List<GameObject> TerrenosActuales = new List<GameObject>();
    [SerializeField] private List<TerrainData> infoTerreno = new List<TerrainData>();
    [SerializeField] private int LimiteTerreno;
    [SerializeField] private Transform guardarTerreno;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i< LimiteTerreno; i++)
        {
            GenerarT(true);

        }
        LimiteTerreno = TerrenosActuales.Count;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GenerarT(false);
        }
    }

    private void GenerarT(bool inicia)
    {

        int queTerreno = Random.Range(0, infoTerreno.Count);
        int terrenoEnCrecimiento = Random.Range(1, infoTerreno[queTerreno].maxEnFila);
        
        for (int i = 0; i < terrenoEnCrecimiento; i++)
        {
            GameObject terreno = Instantiate(infoTerreno[queTerreno].terreno, pos, Quaternion.identity,guardarTerreno);
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
