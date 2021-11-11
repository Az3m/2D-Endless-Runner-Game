using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    
    
    



    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text =((int)score).ToString();
            PlayerPrefs.SetInt("CurrentScore", (int)score);

        }
         
    }
}
