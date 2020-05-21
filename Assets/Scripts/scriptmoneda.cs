using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptmoneda : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;
    public AudioClip clip;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("moneda"))
        {
            Destroy(col.gameObject);
            source.PlayOneShot(clip);
            
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
