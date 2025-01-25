using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
   public void Jugar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

    public void Menu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   public void Salir() {
        Application.Quit();
   }
}
