using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorDeEscenas : MonoBehaviour
{
    Scene miEscena;
    string Nombre;
    int numeroEscena;

    private void Start()
    {
        miEscena = SceneManager.GetActiveScene();
        Nombre = miEscena.name;
        numeroEscena = miEscena.buildIndex;

    }
    public void cambiaEscena(int indice)
    {

        SceneManager.LoadScene(indice);

    }
   





}
