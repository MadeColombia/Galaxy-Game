using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    [SerializeField] private float velocidad;

    private void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Jugador>() != null)
        {
            Destroy(collision.gameObject);
        }
    }
}
