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
    [SerializeField]
    private SpriteRenderer _renderer;
    
    private int velocitydirection, velocitxdirection; 
    private float velocidadY, velocidadX;
    
        public void Update()   
    {
        posicion = transform.position;

        transform.position = transform.position + new Vector3((velocitxdirection * velocidad * Time.deltaTime), (velocitydirection * velocidad * Time.deltaTime), 0);

        posicion = transform.position;

        Animation(velocitydirection, velocitxdirection);
    }


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
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_0"); 
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_1"); 
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_2"); 
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_3"); 
                    break;
                case 5:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_4"); 
                    break;
                case 6:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_5"); 
                    break;
            }
        }
        else if (posX > 0 && posY == 0)
        {
            //Horrizontal derecha
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
        else if (posX > 0 && posY < 0)
        {   
            //Diagonal para abajo derecha
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_0"); 
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_1"); 
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_2"); 
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_3"); 
                    break;
                case 5:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_4"); 
                    break;
                case 6:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_5"); 
                    break;

            }
        }
        else if (posX == 0 && posY < 0)
        {
            //Abajo 
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_0"); 
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_1"); 
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_2"); 
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_3"); 
                    break;
                case 5:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_4"); 
                    break;
                case 6:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_5"); 
                    break;

            } 
        }
        else if (posX < 0 && posY < 0)
        {
            //Izquierda abajo
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_0"); 
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_1"); 
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_2"); 
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_3"); 
                    break;
                case 5:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_4"); 
                    break;
                case 6:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_5"); 
                    break;

            }
        }
        else if (posX < 0 && posY == 0)
        {
            //izquierda
            switch (contadorLoopSprite)
            { 
                case 1:
                    _renderer.sprite = Load("Sprites/Diva", "divaIzquierda_0"); 
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "divaIzquierda_1"); 
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "divaIzquierda_2"); 
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "divaIzquierda_3"); 
                    break;
                case 5:
                    _renderer.sprite = Load("Sprites/Diva", "divaIzquierda_4"); 
                    break;
                case 6:
                    _renderer.sprite = Load("Sprites/Diva", "divaIzquierda_5"); 
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
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_0");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_1");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_2");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_3");
                    break;
                case 5:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_4");
                    break;
                case 6:
                    _renderer.sprite = Load("Sprites/Diva", "divaDiagonal_5");
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