using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OnDeathEvent : MonoBehaviour
{
    public GameObject gameOverPanel;


    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player") == null)
        {
            if (PlayerPrefs.GetInt("CurrentScore") > PlayerPrefs.GetInt("HighScore", 0))
            {
                //sets the current score as the high score if it is larger...theoretically...
                PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("CurrentScore"));
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    

    
}
