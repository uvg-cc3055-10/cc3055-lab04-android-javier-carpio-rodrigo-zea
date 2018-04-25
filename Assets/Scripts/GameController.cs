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
    public bool gameOver = false;
    public static GameController instance;
    public Double delTime = 0;
    public Text time;
    // Use this for initialization
    private void Awake()
    {
        instance = this;
    }
    void Start () {
        
        //time = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOver == false)
        {
            
            delTime += Math.Round(Time.deltaTime, 2);
            time.text = "Score: " + delTime.ToString("#.##");
        }
        
	}


}
