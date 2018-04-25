using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* UVG 
Programación Plataformas Móviles y Videojuegos - Sección 10
Javier Carpio - 17077 y Rodrigo Zea - 17058 
gameController Script */

public class GameController : MonoBehaviour {
    /*Declarar variable para seguir en el juego*/
    public bool gameOver = false;
    /*Instancia para GameController*/
    public static GameController instance;
    /*Tiempo transcurrido para score*/
    public Double delTime = 0;
    /*UI para mostrar texto con score*/
    public Text time;
    // Use this for initialization
    private void Awake()
    {
        /*Se crea el instance al ejecutarse el programa*/
        instance = this;
    }
    void Start () {
        
        //time = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOver == false)
        {
            /*Se realiza la suma para el score*/
            delTime += Math.Round(Time.deltaTime, 2);
            /*Se muestra en pantalla el score*/
            time.text = "Score: " + delTime.ToString("#.##");
        }
        
	}


}
