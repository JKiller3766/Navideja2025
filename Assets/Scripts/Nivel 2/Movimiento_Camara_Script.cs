using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoObjeto : MonoBehaviour
{
    [SerializeField] private float velocidad; 
    private Vector2 moveInput;
    private Rigidbody2D playerRb;

    public Vector2 posicion;

    [SerializeField] public Transform huevo;

    public void Start()
    { 
        playerRb = GetComponent<Rigidbody2D>();
        playerRb.MovePosition(new Vector2(0, -3));
    }

    public void Update()  
    {
        moveInput = new Vector2(0, 1);
    } 
    
    private void FixedUpdate()
    {  
        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);

        if (huevo.position.y == playerRb.position.y)
        {
            Destroy(huevo);
            SceneManager.LoadScene(5); //escena 2 es el juego
        }
    }
   
}
