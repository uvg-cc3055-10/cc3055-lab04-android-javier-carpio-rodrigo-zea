using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* UVG 
Programación Plataformas Móviles y Videojuegos - Sección 10
Javier Carpio - 17077 y Rodrigo Zea - 17058 
Asteroid Script */
public class Asteroid : MonoBehaviour {
    Rigidbody2D rb;
    public float speed = 7f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (rb.position.y <= -5.40 )
        {
            Destroy(gameObject);
        }
	}
}
