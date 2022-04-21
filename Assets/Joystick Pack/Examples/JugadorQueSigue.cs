using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorQueSigue : MonoBehaviour
{
    public Transform pelota;
    public float velocidad =.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pelota.position, Time.deltaTime*velocidad);
    }
}
