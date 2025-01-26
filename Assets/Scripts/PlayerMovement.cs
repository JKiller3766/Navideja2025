using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using UnityEngine.UI;
using UnityEngine.UIElements;
//Luca he quitado el using System que es por lo que no podias generar numeros aleatorios prueba ahora a poner lo que te pase ayer del cambio de posición
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocidad = 100f;
    public GameObject huevoPrincipal;
    //private int contadorLoopSprite = 1;
    //private bool subiendoContador = true;
    //[SerializeField]
    //private SpriteRenderer _renderer;
    public Animator playerAnimator;
    private Vector2 moveInput;
    private Rigidbody2D playerRb;

    
    public void Start()
    {

        //contadorLoopSprite = 1;
        //subiendoContador = true;
        playerAnimator = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody2D>();
    }

    public void Update()  
    {

        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(inputHorizontal, inputVertical).normalized;

        playerAnimator.SetFloat("Horizontal", inputHorizontal);
        playerAnimator.SetFloat("Vertical", inputVertical);
        playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);
        //Vector3 posicion = transform.position;

        //transform.position = posicion + new Vector3(inputHorizontal * Time.fixedDeltaTime, inputVertical * Time.fixedDeltaTime, 0);

        //CambioDeSprite(inputX, inputY);
    } 
    
    private void FixedUpdate()
    {  
        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);
    }
    /*

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
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_1");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_2");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_3");
                    break;

            }
        }
        else if (posX > 0 && posY > 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_4");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_5");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_6");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_7");
                    break;

            }
        }
        else if (posX > 0 && posY == 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_8");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_9");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_10");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_11");
                    break;

            }
        }
        else if (posX > 0 && posY < 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_12");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_13");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_14");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_15");
                    break;

            }
        }
        else if (posX == 0 && posY < 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_16");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_17");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_18");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_19");
                    break;

            }
        }
        else if (posX < 0 && posY < 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_20");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_21");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_22");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_23");
                    break;

            }
        }
        else if (posX < 0 && posY == 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_24");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_25");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_26");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_27");
                    break;

            }
        }
        else if (posX < 0 && posY > 0)
        {
            switch (contadorLoopSprite)
            {
                case 1:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_28");
                    break;
                case 2:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_29");
                    break;
                case 3:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_30");
                    break;
                case 4:
                    _renderer.sprite = Load("Sprites/huevosprite", "huevosprite_31");
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

    }*/
}