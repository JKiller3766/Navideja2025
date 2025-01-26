using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.Rendering.HableCurve;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemy;
    private int xLimits = 19; // x axis limits
    private int yLimits = 12; // y axis limits
    [SerializeField] private float contadorTiempo;
    private int contadorDificultad = 1;

    private Vector2 coordinates = new Vector3(0f, 0f);
    [SerializeField] public Transform huevo;

    void Start()
    {
        InvokeRepeating("SpawnREnemy", 1f, 0.5f);
    }


        void FixedUpdate()
        {
            if (contadorTiempo > 0)
            {
            contadorTiempo -= Time.fixedDeltaTime;
            }
            
            if (contadorTiempo <= 270 && contadorDificultad == 1){
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;

            } else if (contadorTiempo <= 240 && contadorDificultad == 2)
            {
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;
            }
            else if (contadorTiempo <= 210 && contadorDificultad == 3)
            {
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;
            }
            else if (contadorTiempo <= 180 && contadorDificultad == 4)
            {
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;
            }
            else if (contadorTiempo <= 150 && contadorDificultad == 5)
            {
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;
            }
            else if (contadorTiempo <= 120 && contadorDificultad == 6)
            {
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;
            }
            else if (contadorTiempo <= 90 && contadorDificultad == 7)
            {
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;
            }
            else if (contadorTiempo <= 60 && contadorDificultad == 8)
            {
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;
            }
            else if (contadorTiempo <= 30 && contadorDificultad == 9)
            {
                InvokeRepeating("SpawnREnemy", 1f, 0.5f);
                contadorDificultad++;
            }

    }

    // 
    void SpawnREnemy()
    {
        float positionx = Random.Range(-xLimits, xLimits);
        float positiony = Random.Range(-yLimits, yLimits);

        Vector3 posicion = huevo.position;

        while (!(positionx < posicion.x - 3 || positionx > posicion.x + 3))
        {
            positionx = Random.Range(-xLimits, xLimits);

        }

        while (!(positiony < posicion.y - 3 || positiony > posicion.y + 3))
        {
            positiony = Random.Range(-yLimits, yLimits);
        }

        coordinates = new Vector2(positionx, positiony);
        Instantiate(enemy, coordinates, enemy.transform.rotation);
    }
}