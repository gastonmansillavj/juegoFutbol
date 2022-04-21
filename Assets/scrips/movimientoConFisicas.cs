using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoConFisicas : MonoBehaviour
{

    public float velocidadmovimiento = 100;
    public float angulo;
    public float velocidadDeRotacion=50;
    float xcomponent;
    float ycomponent;
    public float tiempo=0;
    public bool ActivaPatada= true;

    public bool enArea = false;
    /// stick
    public Joystick mueve;
    /// 
    void Start()
    {
      
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        //angulo = transform.rotation.y;


        //////
        if (Input.GetKey(KeyCode.D) || mueve.Horizontal > 0.2 && !enArea)
        {
           
                transform.Rotate(0, velocidadDeRotacion * Time.deltaTime, 0);
                angulo += -(velocidadDeRotacion) * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A) || (mueve.Horizontal < -0.2) && !enArea)
        {           
                transform.Rotate(0, -(velocidadDeRotacion) * Time.deltaTime, 0);
                angulo += velocidadDeRotacion * Time.deltaTime;

        }

        if ((Input.GetKey(KeyCode.W)|| mueve.Vertical>0.3) && ActivaPatada && !enArea)
        {
            //transform.Translate(new Vector3(10, 0, 0) * Time.deltaTime * velocidadMovimiento);
            //GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 5 * Time.deltaTime * velocidadmovimiento ), ForceMode.Force);

            //rb.AddForce(rb.transform.forward);

            //AddForceAtAngle(100, transform.rotation.y);
            //angulo*= Mathf.Deg2Rad;
            // angulo =-(GetComponent<Transform>().rotation.y)*100f;
           
           
            xcomponent = Mathf.Cos(angulo * Mathf.PI / 180) * 10f;
            ycomponent = Mathf.Sin(angulo * Mathf.PI / 180) * 10f;
            GetComponent<Rigidbody>().AddForce(new Vector3(xcomponent * Time.deltaTime * velocidadmovimiento, 0, ycomponent * Time.deltaTime * velocidadmovimiento), ForceMode.Force);

            //float xcomponent = Mathf.Cos(angulo * Mathf.PI / 180) * force;
            //float ycomponent = Mathf.Sin(angulo * Mathf.PI / 180) * force;

            ActivaPatada = false;
            Invoke("activaPatada", 0.25f); 
        }



    }

    void Update()
    {
        //tiempo = tiempo -1 * Time.deltaTime;




        ///////

        print("esto es horizontal"+mueve.Horizontal);
        print("esto es vertical" + mueve.Vertical);


       
    }
    void activaPatada()
    {
        ActivaPatada = true;
    }
    public void estaEnArea ()
    {
        enArea = true;
    }

}
