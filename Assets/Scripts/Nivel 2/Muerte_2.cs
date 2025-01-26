using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Muerte_2 : MonoBehaviour
{
    private Rigidbody2D playerRb;

    public void Start()
    { 
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerRb.position.y > 156) {
            SceneManager.LoadScene(5);
        }
    }
}
    