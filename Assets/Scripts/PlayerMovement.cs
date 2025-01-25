using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private float velocidad = 1f;
    public GameObject huevoPrincipal;
    private int contadorLoopSprite = 1;
    private Boolean subiendoContador = true;
    [SerializeField]
    private SpriteRenderer _renderer;

    public void Start()
    {
        contadorLoopSprite = 1;
        subiendoContador = true;
    }

    public void Update()
    {
        float velocidadX = Input.GetAxisRaw("Horizontal");
        float velocidadY = Input.GetAxisRaw("Vertical");
        
        Vector3 posicion = transform.position;
        CambioDeSprite(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        transform.position = transform.position + new Vector3(velocidadX * velocidad * Time.deltaTime, velocidadY * velocidad * Time.deltaTime, 0);

        posicion = transform.position;


    }

    /*public void FixedUpdate()
    {
        if (timeCounter % 5 == 0
            ) {
            CambioDeSprite(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
    }*/

    Sprite Load(string imageName, string spriteName)
    {
        Sprite[] all = Resources.LoadAll<Sprite>(imageName);

        foreach (var s in all)
        {
            if (s.name == spriteName)
            {
                return s;
            }
        }
        return null;
    }

    private void CambioDeSprite(float posX, float posY)
    {

        if (posX == 0.0 && posY == 0.0)
        {
            _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_0");
        }
        else if (posX == 0 && posY > 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_0");
                    Debug.Log("1");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite_0", "huevosprite_1");
                    Debug.Log("2");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_2");
                    Debug.Log("3");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_3");
                    Debug.Log("4");
                    break;

            }
        }
        else if (posX > 0 && posY > 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_4");
                    Debug.Log("5");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_5");
                    Debug.Log("6");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_6");
                    Debug.Log("7");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_7");
                    Debug.Log("8");
                    break;

            }
        }
        else if (posX > 0 && posY == 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_8");
                    Debug.Log("9");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_9");
                    Debug.Log("10");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_10");
                    Debug.Log("11");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_11");
                    Debug.Log("12");
                    break;

            }
        }
        else if (posX > 0 && posY < 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_12");
                    Debug.Log("13");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_13");
                    Debug.Log("14");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_14");
                    Debug.Log("15");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_15");
                    Debug.Log("16");
                    break;

            }
        }
        else if (posX == 0 && posY < 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_16");
                    Debug.Log("17");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_17");
                    Debug.Log("18");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_18");
                    Debug.Log("19");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_19");
                    Debug.Log("20");
                    break;

            }
        }
        else if (posX < 0 && posY < 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_20");
                    Debug.Log("21");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_21");
                    Debug.Log("22");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_22");
                    Debug.Log("23");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_23");
                    Debug.Log("24");
                    break;

            }
        }
        else if (posX < 0 && posY == 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_24");
                    Debug.Log("25");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_25");
                    Debug.Log("26");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_26");
                    Debug.Log("27");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_27");
                    Debug.Log("28");
                    break;

            }
        }
        else if (posX < 0 && posY > 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_28");
                    Debug.Log("29");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_29");
                    Debug.Log("30");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_30");
                    Debug.Log("31");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_31");
                    Debug.Log("32");
                    break;

            }
        }

        if (subiendoContador == true)
        {
            if (contadorLoopSprite == 4)
            {
                subiendoContador = false;
                contadorLoopSprite--;
            }
            else
            {

                contadorLoopSprite++;
            }
        }
        else
        {
            if (contadorLoopSprite == 1)
            {
                subiendoContador = true;
                contadorLoopSprite++;
            }
            else
            {
                contadorLoopSprite--;
            }
        }

    }
}