using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class INTRO : MonoBehaviour
{

    //public GameObject J1;
    //Vector3 v = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Object.Destroy(gameObject, 10f);
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Object.Destroy(gameObject, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Object.Destroy(gameObject, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Object.Destroy(gameObject, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Object.Destroy(gameObject, 0f);
        }

    }
}
