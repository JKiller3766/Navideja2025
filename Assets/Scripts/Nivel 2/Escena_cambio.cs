using UnityEngine;

public class Escena_cambio : MonoBehaviour
{
    public GameObject fondo;
    private float seg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        seg = 0;
        fondo.SetActive(true); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        seg = Time.fixedDeltaTime;
        if(seg>5) {
            fondo.SetActive(false); 
            Destroy(fondo); 
        }
    
    }
}
