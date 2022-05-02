using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorDeEscenas : MonoBehaviour
{
    Scene miEscena;
    string Nombre;
   
    int NumeroScena;
    public Animator Fade;
    public float tiempoEsperaFade=1f;
    public float tiempoRetrasoFade=1f;

    // aca va el emty de los botones de interfaz
    public GameObject BotonesInterfaz;

    /// manejadorDenivelesMenuPrincipal
    private int nivelMenu;

    private void Start()
    {
        
        miEscena = SceneManager.GetActiveScene();
        Nombre = miEscena.name;
       

    }
    private void Update()
    {
        // si esta en menu entonces ejecutar esta linea
        if (miEscena.buildIndex==0)
        {
            nivelMenu = GetComponent<manejoCamarasMenu>().nivel;
        }
        
    }
    public void cambiaEscena(int indice)
    {
        BotonesInterfaz.SetActive(true);
       
        StartCoroutine(fadeEscena(indice));

    }

    public void GuardaScena(int escena)
    {
        PlayerPrefs.SetInt("ScenaJugada", escena);
    }

    public void CargaScena()
    {
        NumeroScena = PlayerPrefs.GetInt("ScenaJugada", 0);
    }

    public void Reintentar()
    {
        CargaScena();
        StartCoroutine(fadeEscena(NumeroScena));
        //SceneManager.LoadScene(NumeroScena);

    }
    public void Siguiente()
    {
        
        CargaScena();
        print("numero escena= " + NumeroScena);
        if (NumeroScena == 5)
        {// si la escena anterior es  == a 5  buelve al menu
           
            StartCoroutine(fadeEscena(0));
        }
        else
        {
            
           
            StartCoroutine(fadeEscena(NumeroScena + 1));
        }
       
        //SceneManager.LoadScene(NumeroScena+1);

    }

    public IEnumerator fadeEscena (int indiceEscena)
    {   // activamos la animacion de fade
        // Fade.SetTrigger("iniciaLaTransicion");
        Invoke("retrasoFade",tiempoRetrasoFade);
        /// desactivamos la interfaz
        
        BotonesInterfaz.SetActive(false);

        //detenemos la linea de ejecución por un segundo
        yield return new WaitForSeconds(tiempoEsperaFade);

        //print("cargo escena");
            
            // cargamos la escena 
        
        SceneManager.LoadScene(indiceEscena);
 
    }

    void retrasoFade()
    {
        Fade.SetTrigger("iniciaLaTransicion");
    }



    public void manejoNivelMenu()
    {
        if (nivelMenu==1)
        {
            cambiaEscena(3);
        }
        else if (nivelMenu == 2)
        {
            cambiaEscena(4);
        }
        else if (nivelMenu == 3)
        {
            cambiaEscena(5);
        }
        else
        {
            print("el nivel no esta disponible ");
        }

    }



}
