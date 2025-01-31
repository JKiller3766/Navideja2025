using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
   public void Jugar(){
        SceneManager.LoadScene(1); //escena 1 es la cinematica
   }

   public void Salir() {
        Debug.Log("Salir...");
        Application.Quit();
   }
}
