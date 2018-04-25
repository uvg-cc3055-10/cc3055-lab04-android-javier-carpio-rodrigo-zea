using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/* UVG 
Programación Plataformas Móviles y Videojuegos - Sección 10
Javier Carpio - 17077 y Rodrigo Zea - 17058 
startButton Script */
public class startButton : MonoBehaviour {
    public Text highscore;
	// Use this for initialization
	void Start () {
        /*Llama al metodo para asignar el puntaje*/
        setText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeScene()
    {
        /*Al momento de dar clic al boton, cambia de escena*/
        SceneManager.LoadScene("Level1");    
    }

    public void setText()
    {
        /*Asigna el puntaje*/
        highscore.text = "Highscore: " + PlayerPrefs.GetFloat("Highscore");
    }
}
