using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigoPasaEscena : MonoBehaviour
{
    public Animator personajePrincipal;
    public GameObject manejadorEscenas;
    public int NivelActual;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "pelotaFisica")
        {
            personajePrincipal.SetBool("parado", false);
            personajePrincipal.SetBool("corre", false);
            manejadorEscenas.GetComponent<ManejadorDeEscenas>().GuardaScena(NivelActual);
            manejadorEscenas.GetComponent<ManejadorDeEscenas>().cambiaEscena(2);


        }
       
    }
}
