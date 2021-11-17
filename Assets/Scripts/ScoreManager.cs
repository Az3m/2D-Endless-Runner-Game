using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private static float score;
    private BulletPhysics BulletPhysics;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
            scoreText.color = Color.white;
            if(BulletPhysics.getHit() == true)
            {
                score += 1;
                BulletPhysics.setHit(false);
            }
            
        }
        else
        {
            if (score > PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", (int)score);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
         
    }
    public static int getCurrentScore()
    {
        return (int)score;
    }
    public static void setCurrentScore(int value)
    {
        score = value;
    }
}
