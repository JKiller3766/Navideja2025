using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
   public void Jugar(){
        SceneManager.LoadScene(2); //escena 1 es el juego
   }

   public void Salir() {
        Debug.Log("Salir...");
        Application.Quit();
   }
}
