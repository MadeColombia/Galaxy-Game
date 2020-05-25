using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    [SerializeField] public GameObject jugador;
    [SerializeField] public Vector3 offset;
    [SerializeField] public float smoothness;
    void Update()
    {
        if (jugador != null)
        {
            transform.position = Vector3.Lerp(transform.position, jugador.transform.position + offset, smoothness);
        }
        

    }
}
