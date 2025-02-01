using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaMitad : MonoBehaviour
{
    private int tiempo2;
    void Start()
    {
        tiempo2 = 0;
    }
    void FixedUpdate()
    {
        tiempo2++;
        if (tiempo2 == 280)
        {
            Escena2();
        }
    }
    public void Escena2()
    {
        SceneManager.LoadScene(4);
    }
}
