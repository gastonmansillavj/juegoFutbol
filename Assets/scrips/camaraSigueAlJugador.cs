using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraSigueAlJugador : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 espacioEntreAmbos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objetivo.position + espacioEntreAmbos; 
        //transform.LookAt(objetivo);
    }
}
