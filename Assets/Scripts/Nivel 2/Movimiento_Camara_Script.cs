using UnityEngine;

public class MovimientoObjeto : MonoBehaviour
{
    [SerializeField] private float velocidad; 
    private Vector2 moveInput;
    private Rigidbody2D playerRb;

    public Vector2 posicion;
    
    public void Start()
    { 
        playerRb = GetComponent<Rigidbody2D>();
        playerRb.MovePosition(new Vector2(0, 0));
    }

    public void Update()  
    {
        moveInput = new Vector2(0, 1).normalized;
    } 
    
    private void FixedUpdate()
    {  
        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);
    }
   
}
