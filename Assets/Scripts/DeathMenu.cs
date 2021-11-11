using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{
    public Text CurrentScore;
    public Text HighScore;
    // Start is called before the first frame update
    void Start()
    {
        CurrentScore.text = (PlayerPrefs.GetInt("CurrentScore")).ToString();
        HighScore.text = (PlayerPrefs.GetInt("HighScore")).ToString();
    }

}
