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
    [SerializeField] private float velocidad = 3f;
    private float velocitydirection, velocitxdirection; 
    private Vector2 moveInput;
    private Rigidbody2D enemyRb;
    public Animator enemyAnimator;


    public void Update()   
    {
        moveInput = new Vector2(velocitxdirection, velocitydirection).normalized;
        enemyAnimator.SetFloat("Horizontal", velocitxdirection);
        enemyAnimator.SetFloat("Vertical", velocitydirection);
        enemyAnimator.SetFloat("Speed", moveInput.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        enemyRb.MovePosition(enemyRb.position + moveInput * velocidad * Time.fixedDeltaTime);
    }

    void Start() {
        do
        {
            velocitydirection = Random.Range(-1, 2);
            velocitxdirection = Random.Range(-1, 2);
        } while (velocitxdirection == 0 && velocitydirection == 0);

        enemyAnimator = GetComponent<Animator>();
        enemyRb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gameObject.SetActive(false);
        //soundManager.selectedAudio(0, 0.5f);
        Destroy(gameObject); 
    }

}