using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class manejadorCinemachine : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camaraDisparo;
    // Start is called before the first frame update
    void Start()
    {
        camaraDisparo.gameObject.SetActive(false);
        //camaraDisparo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name=="Capsule")
        {
            camaraDisparo.gameObject.SetActive(true);
            other.GetComponent<movimientoConFisicas>().estaEnArea();
        }
        
    }
}
