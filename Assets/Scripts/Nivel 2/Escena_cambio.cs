    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class Escena_cambio : MonoBehaviour
{
    public GameObject fondo;
    private float seg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        seg = 0;
        gameObject.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DestroyObject", 2f); 
    
    }

    void DestroyObject() {
        gameObject.SetActive(false);
        //soundManager.selectedAudio(0, 0.5f);
        Destroy(gameObject); 
    }
}
