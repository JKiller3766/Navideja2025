using UnityEngine;
using UnityEngine.SceneManagement;

public class Muerte_Nivel2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player")) // Verifica si el objeto tiene la Tag "Player"
        {
            SceneManager.LoadScene(6);
        }
    }
}

