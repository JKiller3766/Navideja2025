using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevos_enemigos : MonoBehaviour
{ 
    //private SoundManager soundManager;    
    public GameObject enemy; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float velocidad = 7f;
    private Vector3 posicion;
    
    private int velocitydirection, velocitxdirection; 
    private float velocidadY, velocidadX;

    private void Avake() {
        //soundManager = FindFirstObjectByType<SoundManager>();
    }

    public void Update()
    {
        velocitydirection = Random.Range(-1, 1);
        velocitxdirection = Random.Range(-1, 1);
        Debug.Log(velocitxdirection);

        posicion = transform.position;

        transform.position = transform.position + new Vector3((velocitxdirection * velocidad * Time.deltaTime), (velocitydirection * velocidad * Time.deltaTime), 0);

        posicion = transform.position;

    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gameObject.SetActive(false);
        Debug.Log("Holaaa");
        //soundManager.selectedAudio(0, 0.5f);
        Destroy(gameObject); 
    }

}
