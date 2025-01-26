using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscenaJuego : MonoBehaviour
{
    private int tiempo;
    void Start(){
        tiempo = 0;
    }
    void FixedUpdate(){
        tiempo++;
        if(tiempo == 3180){
            Escena1();
        }
    }
   public void Escena1()
   {
    SceneManager.LoadScene(2); //escena 2 es el juego
   }
}
