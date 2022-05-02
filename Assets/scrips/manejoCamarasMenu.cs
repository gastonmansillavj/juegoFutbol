using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manejoCamarasMenu : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public int nivel = 1;
    public Sprite estadio1;
    public Sprite estadio2;
    public Sprite estadio3;
    public Image interfaz;


    // Start is called before the first frame update
    void Start()
    {
        Cam1.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nivel == 1)
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            interfaz.sprite = estadio1;
        }
        else if (nivel == 2) {
            Cam2.SetActive(true);
            Cam1.SetActive(false);
            Cam3.SetActive(false);
            interfaz.sprite = estadio2;
        }
        else if (nivel == 3)
        {
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(true);
            interfaz.sprite = estadio3;
        }
        else
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
        }

        if (nivel > 3)
        {
            nivel = 1;
        }

        if (nivel < 1)
        {
            nivel = 3;
        }
    }

    public void aumentaNivel()
    { 
        nivel += 1;
    }
    public void reduceNivel()
    {
         nivel -= 1;
             
    }
}
