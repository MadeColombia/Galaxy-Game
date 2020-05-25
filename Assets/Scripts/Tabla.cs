using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabla : MonoBehaviour
{
    [SerializeField] private float velocidad;
    public bool isTab;
    private void Start()
    {
       
        velocidad = Random.Range(2,4);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        Object.Destroy(gameObject, 15f);

    }
}
