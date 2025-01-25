using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Luca_PlayerMovement : MonoBehaviour {
    private float velocidad = 7f;
    private Vector3 posicion;

    public void Start()
    {
        
    }

    public void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal");
        float velocidadY = Input.GetAxis("Vertical");

        posicion = transform.position;

        transform.position = transform.position + new Vector3(velocidadX * velocidad * Time.deltaTime, velocidadY * velocidad * Time.deltaTime, 0);

        posicion = transform.position;

    }

}