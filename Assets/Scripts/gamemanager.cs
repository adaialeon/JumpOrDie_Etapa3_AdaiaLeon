using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public static gamemanager Instance;

    public int vidas = 3;

    public int puntos = 0;

    public GameObject[] Corazones;

    //public GameObject[] Estrellas;

    public GameObject HUD;

    public GameObject Marco;

    public GameObject Victoria;

    public GameObject Derrota;

    public GameObject Jugador;

    public int contadorEstrellas;

    public Text estrellaText;

    // Start is called before the first frame update
    void Awake()
    {
        //Si ya hay una instancia y no soy yo me destruyo
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);

    }

    public void RestarVidas()
    {
        vidas--;

        if(vidas == 2)
        {
            Corazones[2].SetActive(false);
        }

        if(vidas == 1)
        {
            Corazones[1].SetActive(false);
        }

         if(vidas == 0)
        {
            HUD.SetActive(false);
            Marco.SetActive(true);
            Derrota.SetActive(true);
            Jugador.SetActive(false);
        }

         /*if(estrellas == 10)
        {
            HUD.SetActive(false);
            Marco.SetActive(true);
            Victoria.SetActive(true);
            Jugador.SetActive(false);
        }*/
    }

    public void SumarEstrellas()
    {
        contadorEstrellas = contadorEstrellas + 1;
        Debug.Log("estrellita " + contadorEstrellas);
        estrellaText.text = contadorEstrellas.ToString();

        if(contadorEstrellas == 10)
        {
            HUD.SetActive(false);
            Marco.SetActive(true);
            Victoria.SetActive(true);
            Jugador.SetActive(false); 
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}