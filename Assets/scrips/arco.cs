using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arco : MonoBehaviour
{
    public GameObject ManejadorEscena;
    public int escena;
    public GameObject pelotaEntraArco;
    private void OnTriggerEnter(Collider other)
    {
        // other.gameObject.name == "pelotaSpawn(Clone)"
        // recordar que cuando se instancia el objeto cambia su nombre a clone
        // si no tiene rigidbody no detecta las collisiones ni los trigers
        if (other.gameObject.name == "pelotaSpawn(Clone)")
        {
            
            ManejadorEscena.GetComponent<ManejadorDeEscenas>().GuardaScena(escena);
            ManejadorEscena.GetComponent<ManejadorDeEscenas>().cambiaEscena(1);
            
        }
    }
}
