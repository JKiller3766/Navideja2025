using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemy;
    private int xLimits = 19; // x axis limits
    private int yLimits = 12; // y axis limits

    private Vector2 coordinates = new Vector3(0f, 0f);
    [SerializeField] public Transform huevo;

    void Start()
    {
        InvokeRepeating("SpawnREnemy", 2f, 0.5f);
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

//<> && coordinates.y < posicion.y - 3 || coordinates.y > posicion.y