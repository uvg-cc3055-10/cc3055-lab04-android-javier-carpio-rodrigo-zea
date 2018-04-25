using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* UVG 
Programación Plataformas Móviles y Videojuegos - Sección 10
Javier Carpio - 17077 y Rodrigo Zea - 17058 
Asteroid Script */

public class Asteroid : MonoBehaviour {

    /*Se declara un Rigidbody*/
    Rigidbody2D rb;
    /*Se asigna velocidad de 7.00*/
    public float speed = 7f;

    // Use this for initialization
    void Start () {
        /*Se llaman todos los componentes del Rigidbody*/
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        /*Se realiza el desplazamiento vertical de los asteroides*/
        rb.transform.Translate(Vector2.down * speed * Time.deltaTime);

        
        if (rb.position.y <= -5.40 )
        {
            /*Al llegar al final de la pantalla, se destruye el asteroide*/
            Destroy(gameObject);
        }
	}
}
