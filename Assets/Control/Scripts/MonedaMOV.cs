using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaMOV : MonoBehaviour
{
    private float vel = 0.5f;
    private float delta = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 2, 0);
        float y = Mathf.PingPong(vel * Time.time, delta);
        Vector3 pos = new Vector3(transform.position.x, y + 1f, transform.position.z);
        transform.position = pos;

    }
}
