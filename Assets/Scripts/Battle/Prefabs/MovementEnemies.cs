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

    void Start() {
        velocitydirection = Random.Range(-1, 1);
        velocitxdirection = Random.Range(-1, 1);
        if(velocitydirection == 0) {
            velocitxdirection = 1;
        } else if (velocitxdirection == 0) {
            velocitydirection = 1;
        }
    }

    public void Update()   
    {

        posicion = transform.position;

        transform.position = transform.position + new Vector3((velocitxdirection * velocidad * Time.deltaTime), (velocitydirection * velocidad * Time.deltaTime), 0);

        posicion = transform.position;
        
        if (posX == 0.0 && posY == 0.0)
        {
            //Parado
            _renderer.sprite = Load("Sprites/Diva", "Diva_0");
        }
        else if (posX == 0 && posY > 0)
        {
            switch (contadorLoopSprite)
            {
                //Derecha
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "divaDerecha_0"); 
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "divaDerecha_1"); 
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "divaDerecha_2"); 
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "divaDerecha_3"); 
                    break;
                case 5:
                    _renderer.sprite = Load("Sprites/Diva", "divaDerecha_4"); 
                    break;
                case 6:
                    _renderer.sprite = Load("Sprites/Diva", "divaDerecha_5"); 
                    break;
                default:
                    break;
            }
        }
        else if (posX > 0 && posY > 0)
        {
            //Diagonal arriba
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_4");
                    Debug.Log("5");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_5");
                    Debug.Log("6");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_6");
                    Debug.Log("7");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_7");
                    Debug.Log("8");
                    break;

            }
        }
        else if (posX > 0 && posY == 0)
        {
            //Horrizontal derecha
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_8");
                    Debug.Log("9");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_9");
                    Debug.Log("10");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_10");
                    Debug.Log("11");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_11");
                    Debug.Log("12");
                    break;

            }
        }
        else if (posX > 0 && posY < 0)
        {   
            //Diagonal para abajo izquierda
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_12");
                    Debug.Log("13");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_13");
                    Debug.Log("14");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_14");
                    Debug.Log("15");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_15");
                    Debug.Log("16");
                    break;

            }
        }
        else if (posX == 0 && posY < 0)
        {
            //Diagonal
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_16");
                    Debug.Log("17");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_17");
                    Debug.Log("18");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_18");
                    Debug.Log("19");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_19");
                    Debug.Log("20");
                    break;

            }
        }
        else if (posX < 0 && posY < 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_20");
                    Debug.Log("21");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_21");
                    Debug.Log("22");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_22");
                    Debug.Log("23");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_23");
                    Debug.Log("24");
                    break;

            }
        }
        else if (posX < 0 && posY == 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_24");
                    Debug.Log("25");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_25");
                    Debug.Log("26");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_26");
                    Debug.Log("27");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_27");
                    Debug.Log("28");
                    break;

            }
        }
        else if (posX < 0 && posY > 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_28");
                    Debug.Log("29");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_29");
                    Debug.Log("30");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_30");
                    Debug.Log("31");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_31");
                    Debug.Log("32");
                    break;

            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gameObject.SetActive(false);
        Debug.Log("Holaaa");
        //soundManager.selectedAudio(0, 0.5f);
        Destroy(gameObject); 
    }

}