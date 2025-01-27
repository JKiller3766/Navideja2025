using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
   public void Jugar(){
        SceneManager.LoadScene(2); //escena 2 juego
   }

   public void Salir() {
        Debug.Log("Salir...");
        Application.Quit();
   }
}
