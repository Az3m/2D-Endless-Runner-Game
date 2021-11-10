using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeScreen : MonoBehaviour
{
    public GameObject score;
    public GameObject welcomeScreen;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        score.SetActive(false);

    }

    public void Play()
    {
        Time.timeScale = 1;
        score.SetActive(true);
        welcomeScreen.SetActive(false);

    }

    
    
}
