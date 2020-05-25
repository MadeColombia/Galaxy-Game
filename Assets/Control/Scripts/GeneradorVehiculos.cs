using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorVehiculos : MonoBehaviour
{
    [SerializeField] private GameObject vehiculo;
    //[SerializeField] private List<GameObject> vehiculos= new List<GameObject>();
    [SerializeField] private Transform posicionCreacion;
    [SerializeField] private float minTiempoSeparacion;
    [SerializeField] private float maxTiempoSeparacion;
    [SerializeField] private bool LadoContrario;
    private void Start()
    {
        StartCoroutine(GenerarVehiculos());
    }

    private IEnumerator GenerarVehiculos() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(Random.Range(minTiempoSeparacion, maxTiempoSeparacion));
            GameObject veh = Instantiate(vehiculo, posicionCreacion.position, Quaternion.identity);
            if (!LadoContrario)
            {
                veh.transform.Rotate(new Vector3(0, 180, 0));
            }

        }
       
    }
}
