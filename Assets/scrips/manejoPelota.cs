using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manejoPelota : MonoBehaviour
{
    public float angulo;
    public float xcomponent;
    public float ycomponent;
    public float velocidadmovimiento= 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
   
    private void OnCollisionEnter(Collision personaje)
    {

       // print("entro en colision");
        //GetComponent<Rigidbody>().AddForce(0,1000f,0);
        angulo = personaje.gameObject.GetComponent<movimientoConFisicas>().angulo;
     //   print(angulo);
        xcomponent = Mathf.Cos(angulo * Mathf.PI / 180) * 10f;
        ycomponent = Mathf.Sin(angulo * Mathf.PI / 180) * 10f;
        GetComponent<Rigidbody>().AddForce(xcomponent  * velocidadmovimiento, 0,ycomponent  * velocidadmovimiento, ForceMode.Force);
        //GetComponent<Rigidbody>().AddForce(new Vector3(xcomponent * Time.deltaTime * velocidadmovimiento, 0, ycomponent * Time.deltaTime * velocidadmovimiento), ForceMode.Force);

    }

}
