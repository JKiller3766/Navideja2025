using UnityEngine;
using UnityEngine.SceneManagement;

public class Muerte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int vidas = 1;
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        vidas--;
    }


    // Update is called once per frame
    void Update()
    {
        if(vidas == 0) {
            SceneManager.LoadScene(3);
        }
    }
}
