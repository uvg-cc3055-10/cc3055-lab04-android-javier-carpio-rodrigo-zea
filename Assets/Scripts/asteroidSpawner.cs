using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* UVG 
Programación Plataformas Móviles y Videojuegos - Sección 10
Javier Carpio - 17077 y Rodrigo Zea - 17058 
asteroidSpawner Script */
public class asteroidSpawner : MonoBehaviour {
    public GameObject asteroid;
    public GameObject asteroid2;
    public GameObject asteroid3;
    bool gameO;

    public float spawnTime = 4f;
    public float elapsedTime = 0f;
	// Use this for initialization
	void Start () {
        gameO = GameController.instance.gameOver;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameO == false)
        {
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-3f, 3f);
                int spawnNumber = Random.Range(1, 3);

                switch (spawnNumber)
                {
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

                elapsedTime = 0;
            }
        }
        
    }
}
