using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* UVG 
Programación Plataformas Móviles y Videojuegos - Sección 10
Javier Carpio - 17077 y Rodrigo Zea - 17058 
Spaceship Script */

public class Spaceship : MonoBehaviour {
    /*Declara variable para velocidad de movimiento*/
    public float speed = 5f;
    /*Crea objeto Rigidbody*/
    Rigidbody2D rb;
    /*Boolena para indicar si ha perdido o no*/
    bool gameO;
    // Use this for initialization
    void Start () {
        /*Se obtienen lso componentes de Rigidbody*/
        rb = GetComponent<Rigidbody2D>();
        /*Se llama el gameOver de GameController*/
        gameO = GameController.instance.gameOver;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameO == false)
        {
            /*Se llama el acelerometro del dispositivo*/
            float movX = Input.acceleration.x;
            /*Se desplaza el Rigidbody*/
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        }
        else
        {
            /*Se obtiene el Highscore*/
            float hscore = PlayerPrefs.GetFloat("Highscore");

            if (GameController.instance.delTime > hscore)
            {
                /*Si el nuevo score es mayor al Highscore, se guarda*/
                PlayerPrefs.SetFloat("Highscore", (float)GameController.instance.delTime);
            }
            
            /*Se regresa al menu principal*/
            SceneManager.LoadScene("MainMenu");
            gameO = false;
        }
        
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameO = true;
        
    }
}
