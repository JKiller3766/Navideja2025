using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemy;   
    private int xLimits = 19; // x axis limits
    private int yLimits = 12; // y axis limits

    private Vector3 coordinates = new Vector3(0f, 0f, 0);

    void Start()
    {
        InvokeRepeating("SpawnREnemy", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 
    void SpawnREnemy() {
        float Positionx = Random.Range(-xLimits, xLimits);
        float Positiony = Random.Range(-yLimits, yLimits);

        Vector3 coordinates = new Vector3(Positionx, Positiony, 0);

        Instantiate(enemy, coordinates, enemy.transform.rotation);
    }
}   