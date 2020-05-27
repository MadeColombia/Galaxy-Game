using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorVehiculos : MonoBehaviour
{
   // [SerializeField] private GameObject vehiculo;
    [SerializeField] private List<GameObject> vehiculos= new List<GameObject>();
    [SerializeField] public Transform posicionCreacion;
    private float minTiempoSeparacion = 5f;
    private float maxTiempoSeparacion = 10f;
    [SerializeField] public bool LadoContrario;
    private void Start()
    {
        StartCoroutine(GenerarVehiculos());
    }

    private IEnumerator GenerarVehiculos() 
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            
            yield return new WaitForSeconds(Random.Range(minTiempoSeparacion, maxTiempoSeparacion));
            
            

            for (int i = 0; i < vehiculos.Count; i++)
            {
                int queVehiculo = Random.Range(0, vehiculos.Count);
                
                GameObject veh = Instantiate(vehiculos[queVehiculo], posicionCreacion.position, Quaternion.identity);
                if (!LadoContrario)
                {
                    veh.transform.Rotate(new Vector3(0, 180, 0));
                }

            }

              

        }
       
    }
}
