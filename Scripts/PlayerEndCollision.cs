using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEndCollision : MonoBehaviour
{
    //Player will collide with portal and load nect scene
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(collision.gameObject.CompareTag("EndPortal"))
        {
            SceneManager.LoadScene("MainMenu");
        }
        
    }
}
