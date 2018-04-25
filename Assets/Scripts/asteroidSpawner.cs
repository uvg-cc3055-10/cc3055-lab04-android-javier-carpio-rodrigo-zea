using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* UVG 
Programación Plataformas Móviles y Videojuegos - Sección 10
Javier Carpio - 17077 y Rodrigo Zea - 17058 
asteroidSpawner Script */

public class asteroidSpawner : MonoBehaviour {
    /*Se declaran todos los objetos Asteroides*/
    public GameObject asteroid;
    public GameObject asteroid2;
    public GameObject asteroid3;
    /*Boolean que nos indica si perdio*/
    bool gameO;

    /*Variable para indicar cuan rapido aparecen los asteroides*/
    public float spawnTime = 4f;
    /*Variable para indicar el tiempo trancurrido*/
    public float elapsedTime = 0f;
	// Use this for initialization
	void Start () {
        /*Se asigna la instancia del GameController a gameO*/
        gameO = GameController.instance.gameOver;
    }
	
	// Update is called once per frame
	void Update () {
        /*Si no ha perdido, sigue la condicional*/
        if (gameO == false)
        {
            if (elapsedTime < spawnTime)
            {
                /*Aumenta con respecto al tiempo*/
                elapsedTime += Time.deltaTime;
            }
            else
            {
                /*Random para indicar posicion en x del asteroide*/
                float random = Random.Range(-3f, 3f);
                /*Random para indicar que asteroide se generara*/
                int spawnNumber = Random.Range(1, 3);

                switch (spawnNumber)
                {
                    /*Direfentes asteroides*/
                    case 1:
                        Instantiate(asteroid, new Vector3(random, 5, 0), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(asteroid2, new Vector3(random, 5, 0), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(asteroid3, new Vector3(random, 5, 0), Quaternion.identity);
                        break;
                }
                /*Se reinicia el tiempo transcurrido*/
                elapsedTime = 0;
            }
        }
        
    }
}
