using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Muerte : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(6);
    }
}
