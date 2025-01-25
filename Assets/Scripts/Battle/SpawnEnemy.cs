using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemy;

    private Vector2 coordinates = new Vector2(0f, 0.99f);

    void Start()
    {
        Instantiate(enemy, coordinates, enemy.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
