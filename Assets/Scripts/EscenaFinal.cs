using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaFinal : MonoBehaviour
{
    private int tiempo3;
    void Start()
    {
        tiempo3 = 0;
    }
    void FixedUpdate()
    {
        tiempo3++;
        if (tiempo3 == 800)
        {
            Escena3();
        }
    }
    public void Escena3()
    {
        SceneManager.LoadScene(0);
    }
}
