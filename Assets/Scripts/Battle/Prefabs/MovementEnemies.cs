using UnityEngine;

public class Huevos_enemigos : MonoBehaviour
{ 
      
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float velocidad = 7f;
    private Vector3 posicion;

    public void Start()
    {
        
    }

    public void Update()
    {
        float velocidadX = 1;
        float velocidadY = 1;

        posicion = transform.position;

        transform.position = transform.position + new Vector3(velocidadX * velocidad * Time.deltaTime, velocidadY * velocidad * Time.deltaTime, 0);

        posicion = transform.position;

    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Holaaa");
        Destroy(this);
    }

}
