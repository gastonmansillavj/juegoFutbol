using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDePuntos : MonoBehaviour
{
    
    public Text Monedas;
    public int monedas;
    public GameObject Jugador;
    public GameObject monedasFisicas;
   

    // Start is called before the first frame update
    void Start()
    {
        CargaMonedas();
      
    }
    private void Update()
    {
    
        Monedas.text = monedas.ToString();
    }
    public void sumaMonedas()
    {
        monedas++;
    }

    private void OnDestroy()
    {
        GuardaMonedas();
    }

    public void GuardaMonedas ()
    {
        PlayerPrefs.SetInt("Monedas",monedas); 
    }

    public void CargaMonedas()
    {
        monedas = PlayerPrefs.GetInt("Monedas",0);
    }

    

}
