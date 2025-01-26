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

        //public PlayerMovement huevoPosition;
    void Start()
        {
            InvokeRepeating("SpawnREnemy", 2f, 0.5f);
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        // 
        void SpawnREnemy() {

            float Positionx = Random.Range(-xLimits, xLimits);
            float Positiony = Random.Range(-yLimits, yLimits);


            Vector2 coordinates = new Vector2(Positionx, Positiony);

            /*while (coordinates.x != huevoPosition.posicion.x)
        {
            Debug.Log("a");
        }*/

            Instantiate(enemy, coordinates, enemy.transform.rotation);
        }
    }   