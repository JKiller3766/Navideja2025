using UnityEngine;

public class Huevos_enemigos : MonoBehaviour
{
    Rigidbody2D enemyRb;
    [SerializeField]
    [Range(2f, 10f)]
    float speed;

    private Vector2 TargetPosition;  
    private Rigidbody2D rb;
      
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }

    private void onCollisionEnter2D(Collision2D collision)
    { 
        //if (collision.gameObeject.tag == "Block")
        //{
          //  Destroy(gameObject);
        //}
    }
}
