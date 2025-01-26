using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerMovement2 : MonoBehaviour
{
    [SerializeField] private float velocidad;
    public GameObject huevoPrincipal;
    public Animator playerAnimator;
    private Vector2 moveInput;
    private Rigidbody2D playerRb;

    public Vector2 posicion;
    
    public void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody2D>();
        playerRb.MovePosition(new Vector2(0, 0));
    }

    public void Update()  
    {

        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(inputHorizontal, inputVertical).normalized;

        playerAnimator.SetFloat("Horizontal", inputHorizontal);
        playerAnimator.SetFloat("Vertical", inputVertical);
        playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);;
    } 
    
    private void FixedUpdate()
    {  
        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);
        posicion = playerRb.position;

        if (playerRb.position.y > 156)
        {
            SceneManager.LoadScene(3);
        }
    }
   
}