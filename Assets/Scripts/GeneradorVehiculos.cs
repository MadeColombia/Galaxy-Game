using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorVehiculos : MonoBehaviour
{
    [SerializeField] private GameObject vehiculo;
    [SerializeField] private Transform posicionCreacion;
    [SerializeField] private float minTiempoSeparacion;
    [SerializeField] private float maxTiempoSeparacion;
    private void Start()
    {
        StartCoroutine(GenerarVehiculos());
    }

    private IEnumerator GenerarVehiculos() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(Random.Range(minTiempoSeparacion, maxTiempoSeparacion));
            Instantiate(vehiculo, posicionCreacion.position, Quaternion.identity);
        }
       
    }
}
