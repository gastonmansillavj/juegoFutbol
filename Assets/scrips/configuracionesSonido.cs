using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class configuracionesSonido : MonoBehaviour
{
    public GameObject PanelConfiguraciones;
    public GameObject botonesInterfaz;
    public float volumeEfectos;
    public float volumeMusica;
    public Slider efectos;
    public Slider musica;

    // efectos de sonido menu 
    public AudioClip botonPlay;
    public AudioClip botonDirecciones;
    public AudioClip musicaMenu;


    // efectos de sonido juego 
    public AudioClip musicaJuego;
    public AudioClip correr;
    public AudioClip juntaMoneda;
    public AudioClip antesDeDisparar;
    public AudioClip pasaAlSiguienteNivel;
    public AudioClip gol;
    public AudioClip gameOver;
    public AudioClip pateaPelota;
    public AudioClip respiracion;
    public AudioClip silbato;


    // animator 
    public AudioSource controladorDeEfectosDeSonido;
    public AudioSource controladorDeMusica;

    // escena 
    private int escenaActual;


    private void Awake()
    {
        
    }
    void Start()
    {
        escenaActual = SceneManager.GetActiveScene().buildIndex;
        cargaEfectosSonidos();
        controladorDeEfectosDeSonido.clip = correr;
        if (escenaActual==0)
        {
            PanelConfiguraciones.SetActive(false);

            ///musicamenu

            controladorDeMusica.clip = musicaMenu;
            controladorDeMusica.Play();
            
            

            // actualiza el slider del juego 
            tomaLosValoresDelSlider();
        }
        else if (escenaActual== 1)
        {

        }
        else if (escenaActual == 2)
        {

        }
        else
        {
            controladorDeMusica.clip =musicaJuego;
            controladorDeMusica.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {

        tomaLosValoresDelSlider();
        controladorDeMusica.volume = volumeMusica;

    }

    private void OnDestroy()
    {
        guardaEfectosSonidos();
    }

    public void muestraConfig()
    {
        botonesInterfaz.SetActive(false);
        PanelConfiguraciones.SetActive(true);
    }
    public void cierraConfig()
    {
        botonesInterfaz.SetActive(true);
        PanelConfiguraciones.SetActive(false);
    }

    public void guardaEfectosSonidos()
    {
        PlayerPrefs.SetFloat("efectos", volumeEfectos);
        PlayerPrefs.SetFloat("musica", volumeMusica);

    }
    public void cargaEfectosSonidos()
    {
        volumeEfectos = PlayerPrefs.GetFloat("efectos", 1.0f);
        volumeMusica = PlayerPrefs.GetFloat("musica", 1f);
        if (escenaActual==0)
        {
            actualizaElVolumenAlSlider();
        }
       
        
        
    }

    public void reproduceBotones ()
    {
        
        reproduceSonidosConVolumen(botonDirecciones, volumeEfectos);
    }
    public void reproduceBotonPlay()
    {
        reproduceSonidosConVolumen(botonPlay, volumeEfectos);
    }

    public void reproduceCorrer()
    {

       
        controladorDeEfectosDeSonido.Play();
        
        

    }
    public void detieneCorrer()
    {

        controladorDeEfectosDeSonido.Stop();

    }
    public void reproduceMoneda()
    {

        reproduceSonidosConVolumen(juntaMoneda, volumeEfectos);

    }



    

    public void reproduceSonidosConVolumen(AudioClip sonidoAReproducir,float volume)
    {

       controladorDeEfectosDeSonido.PlayOneShot(sonidoAReproducir, volume);
        
        

    }
    public void reproduceSonidosConVolumenConstante(AudioClip sonidoAReproducir, float volume)
    {

        print("entra a correr");
        controladorDeEfectosDeSonido.clip = sonidoAReproducir;
        controladorDeEfectosDeSonido.Play();


    }

    public void actualizaElVolumenAlSlider() {
        
        if (escenaActual == 0)
        {           
            efectos.value = volumeEfectos;
            musica.value = volumeMusica;
        }

    }

    public void tomaLosValoresDelSlider()
    {

        if (escenaActual == 0)
        {
            volumeEfectos = efectos.value;
            volumeMusica = musica.value;
        }

    }

    

}
