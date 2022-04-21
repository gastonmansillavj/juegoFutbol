using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class personajeQueSigue : MonoBehaviour
{
    public Transform objetivo;
    NavMeshAgent jugador;
    public float distancia = 100;
    public float velocidadIA = 20;
    Animator animacionEnemigo;
    Transform modeloEnemigo;
    GameObject personajeAnimacion;
    bool paso= false;

    void Start()
    {
        jugador=GetComponent<NavMeshAgent>();
        animacionEnemigo=GetComponent<Animator>();
        personajeAnimacion = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Vector3.Distance(transform.position, objetivo.transform.position) < 20  && !paso)
        {
            animacionEnemigo.SetBool("camina", true);

            jugador.SetDestination(new Vector3(objetivo.transform.position.x, -4f, objetivo.transform.position.z));
            Invoke("jugadorBaja",0.30f);
            Invoke("enemigoDetenido",1);
            



        }

        else if (Vector3.Distance(transform.position,objetivo.transform.position)<distancia && !paso )
        {
            jugador.SetDestination(objetivo.transform.position);
            jugador.speed = velocidadIA;
            

        }
       
        else
        {
            jugador.speed = 0;
            
        }


    }


    void jugadorBaja ()
    {
        personajeAnimacion.transform.localPosition = new Vector3(0, -2f, 0);
    }


    void enemigoDetenido ()
    {
        paso = true;
        jugador.gameObject.SetActive(false);
    }
}
