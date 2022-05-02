using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumaMonedas : MonoBehaviour
{
    public GameObject SumaMonedas;
    public float velocidadDeRotacion = 30;
    bool monedaAbajo=true;
    public Camera MonedaInterfaz;
    public GameObject reproductorDeSonido;

    public float ofsetX = 0f;
    public float ofsetY = 0f;
    public float ofsetZ = 5f;

    public GameObject particulasMonedas;
    private void Update()
    {
        MonedaInterfaz.ViewportToWorldPoint(new Vector3 (0.5f,0.5f,ofsetZ));
        

        transform.Rotate(0, 0, 10 * Time.deltaTime * velocidadDeRotacion);
        if (monedaAbajo==false)
        {
            SubeMoneda();
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            SumaMonedas.GetComponent<ControlDePuntos>().sumaMonedas();
            // muevo las monedas hacia arriba
            
            //gameObject.SetActive(false);
            monedaAbajo = false;
            reproductorDeSonido.GetComponent<configuracionesSonido>().reproduceMoneda();
            
        }
    }

    void SubeMoneda ()
    {
        //gameObject.transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3 (Camera.main, MonedaInterfaz.transform.position.y-ofsetY, MonedaInterfaz.transform.position.z-ofsetZ), Time.deltaTime * 50);


        gameObject.transform.localPosition = Vector3.MoveTowards(transform.localPosition, MonedaInterfaz.ViewportToWorldPoint(new Vector3(0.5f+ofsetX, 0.5f+ofsetY, ofsetZ)), Time.deltaTime * 50);
        //gameObject.transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(transform.localPosition.x, 20f, transform.localPosition.z), Time.deltaTime * 18);
        
        velocidadDeRotacion = 300f;
        particulasMonedas.SetActive(true);
        Invoke("desactivaMoneda",0.5f);
    }

    void desactivaMoneda()
    {
        gameObject.SetActive(false);
    }


    
   
}
