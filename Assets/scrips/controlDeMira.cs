using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlDeMira : MonoBehaviour
{
    public GameObject mira;
    bool activada;
    public Joystick mueve;
    public GameObject pelota;
    public GameObject camara;
    public float rango = 10f;
    public GameObject pelotaADisparar;
    int contadorPelota = 0;
    GameObject pelotaNueva;
    public GameObject pelotaADestruir;
    public GameObject MurosADestruir;
    

    
    // Start is called before the first frame update
    void Start()
    {
        mira.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     

        if (GetComponent<movimientoConFisicas>().enArea == true  )
        {

                if (mueve.enabled)
                { 
                    mira.transform.Translate(new Vector3(0, mueve.Vertical * Time.deltaTime * 20, mueve.Horizontal * Time.deltaTime * -20));
                    mira.SetActive(true); 
                }

            

                if (mira.transform.position.y > 3)
                {
                    mira.transform.position = new Vector3(mira.transform.position.x, 3f, mira.transform.position.z);
                }
                if (mira.transform.position.y < 0)
                {
                    mira.transform.position = new Vector3(mira.transform.position.x, 0f, mira.transform.position.z);
                }
                if (mira.transform.position.z < 22)
                {
                    mira.transform.position = new Vector3(mira.transform.position.x, mira.transform.position.y, 22);
                }
                if (mira.transform.position.z > 37)
                {
                    mira.transform.position = new Vector3(mira.transform.position.x, mira.transform.position.y, 37);
                }
            

            if (contadorPelota==0) {
                pelotaNueva = Instantiate(pelotaADisparar, pelota.transform.position, pelota.transform.rotation);
            contadorPelota+=1;

            }


            if (pelotaNueva)
            {
                Destroy(pelotaADestruir);
                Destroy(MurosADestruir);
                Invoke("disparaPelota",3f);
                
            }
          
        }
        
       
    }
   

    void disparaPelota ()
    {
        mueve.enabled = false;
        mueve.gameObject.SetActive(false);
        pelotaNueva.transform.position = Vector3.MoveTowards(pelotaNueva.transform.position, mira.transform.position, Time.deltaTime * 30f);
        
    }
}
