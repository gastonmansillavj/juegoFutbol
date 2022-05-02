using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlDePuntos : MonoBehaviour
{
    
    public Text Monedas;
    
    public int monedas;
    public int monedaLocal = 0;
   

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            CargaMonedas();
            Monedas.text = monedas.ToString();

        }
        else
        {
            CargaMonedas();
            Monedas.text = monedaLocal.ToString();
        }
        
              
    }

    public void sumaMonedas()
    {
        monedaLocal++;
    }

    private void OnDestroy()
    {
        GuardaMonedas();
    }

    public void GuardaMonedas ()
    {
        monedas = monedas+monedaLocal;
       
        PlayerPrefs.SetInt("Monedas",monedas); 
    }

    public void CargaMonedas()
    {
        monedas = PlayerPrefs.GetInt("Monedas",0);
        

    }

    

}
