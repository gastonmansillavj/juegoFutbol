using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumaMonedas : MonoBehaviour
{
    public GameObject SumaMonedas;
    public float velocidadDeRotacion = 30;
    private void Update()
    {
        transform.Rotate(0, 0, 10 * Time.deltaTime * velocidadDeRotacion);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            SumaMonedas.GetComponent<ControlDePuntos>().sumaMonedas();
            gameObject.SetActive(false);
        }
    }
   
}
