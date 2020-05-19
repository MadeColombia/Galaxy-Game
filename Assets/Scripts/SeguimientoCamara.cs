using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    [SerializeField] private GameObject jugador;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothness;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, jugador.transform.position + offset, smoothness);

    }
}
