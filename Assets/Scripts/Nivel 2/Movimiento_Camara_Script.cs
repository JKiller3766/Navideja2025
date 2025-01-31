using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoObjeto : MonoBehaviour
{
    [SerializeField] private float velocidad; 
    private Vector2 moveInput;
    private Rigidbody2D cameraRb;

    public Vector2 posicion;

    public void Start()
    {
        cameraRb = GetComponent<Rigidbody2D>();
        cameraRb.MovePosition(new Vector2(0, -3));
    }

    public void Update()  
    {
        moveInput = new Vector2(0, 1);
    } 
    
    private void FixedUpdate()
    {
        cameraRb.MovePosition(cameraRb.position + moveInput * velocidad * Time.fixedDeltaTime);
    }
   
}
