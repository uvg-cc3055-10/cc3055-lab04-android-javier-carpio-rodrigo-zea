using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* UVG 
Programación Plataformas Móviles y Videojuegos - Sección 10
Javier Carpio - 17077 y Rodrigo Zea - 17058 
Spaceship Script */
public class Spaceship : MonoBehaviour {
    public float speed = 5f;
    Rigidbody2D rb;
    bool gameO;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        gameO = GameController.instance.gameOver;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameO == false)
        {
            float movX = Input.acceleration.x;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        }
        else
        {
            float hscore = PlayerPrefs.GetFloat("Highscore");

            if (GameController.instance.delTime > hscore)
            {
                PlayerPrefs.SetFloat("Highscore", (float)GameController.instance.delTime);
            }
            
            SceneManager.LoadScene("MainMenu");
            gameO = false;
        }
        
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameO = true;
        
    }
}
