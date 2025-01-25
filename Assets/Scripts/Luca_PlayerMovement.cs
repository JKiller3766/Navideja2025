using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class Luca_PlayerMovement : MonoBehaviour {
    private float velocidad = 7f;
    private Vector3 posicion;
    public GameObject huevoPrincipal;
    private int contadorLoopSprite = 1;

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

    private void cambioDeSprite(int posX, int posY) {

        if (posX == 0 && posY == 0)
        {
            huevoPrincipal.GetComponent<Image>().sprite = Resources
        } else if (posX == 0 && posY == 1)
        {

        }
        else if (posX == 0 && posY == -1)
        {

        }
        else if (posX == 1 && posY == 0)
        {

        }
        else if (posX == 1 && posY == 1)
        {

        }
        else if (posX == 1 && posY == -1)
        {

        }
        else if (posX == -1 && posY == 0)
        {

        }
        else if (posX == -1 && posY == 1)
        {

        }
        else if (posX == -1 && posY == -1)
        {

        }

    }
}