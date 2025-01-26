using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Muerte_2 : MonoBehaviour
{
    private Rigidbody2D playerRb;

    // Update is called once per frame
    void Update()
    {
        if(playerRb.position.y > 170) {
            SceneManager.LoadScene(3);
        }
    }
}
