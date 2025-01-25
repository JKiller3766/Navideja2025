using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Huevos_enemigos : MonoBehaviour
{ 
    //private SoundManager soundManager;    
    public GameObject enemy; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float velocidad = 7f;
    private Vector3 posicion;
    
    private int contadorLoopSprite = 1;
    private bool subiendoContador = true;
    
    private int velocitydirection, velocitxdirection; 
    private float velocidadY, velocidadX;

    private SpriteRenderer _renderer;
    
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
        
        {
            //Izquierda arriba
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

    private void Animation(float posX, float posY) {
        if (posX == 0 && posY > 0)
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
            //Diagonal arriba derecha
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
            //Izquierda abajo
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_20"); 
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_21"); 
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_22"); 
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "Diva_23"); 
                    break;

            }
        }
        else if (posX < 0 && posY == 0)
        {
            //izquierda
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
        else if (posX < 0 && posY > 0)
        {
            //Derecha arriba
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal2_0");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal2_1");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal2_2");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal2_3");
                    break;
                case 5:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal2_4");
                    break;
                case 6:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal2_%");
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

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gameObject.SetActive(false);
        Debug.Log("Holaaa");
        //soundManager.selectedAudio(0, 0.5f);
        Destroy(gameObject); 
    }

}