using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoObjeto : MonoBehaviour
{
    [SerializeField] private float velocidad; 
    private Vector2 moveInput;
    private Rigidbody2D cameraRb;

    public Vector2 posicion;

    private float tiempoEspera;

    public void Start()
    {
        cameraRb = GetComponent<Rigidbody2D>();
        cameraRb.MovePosition(new Vector2(0, -3));
        tiempoEspera = 1;
    }

    public void Update()  
    {
        moveInput = new Vector2(0, 1);
    } 
    
    private void FixedUpdate()
    {
        if (tiempoEspera >= 0)
        {
            tiempoEspera -= Time.fixedDeltaTime;
        }

        if (tiempoEspera <= 0)
        {
            cameraRb.MovePosition(cameraRb.position + moveInput * velocidad * Time.fixedDeltaTime);
        }
        
    }
   
}
