using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    private int PrevSceneToLoad;

    private void Update()
    {
        PrevSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Replay()
    {
        SceneManager.LoadScene(PrevSceneToLoad);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
