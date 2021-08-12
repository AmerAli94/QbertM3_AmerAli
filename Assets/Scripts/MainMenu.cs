using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    //public GameObject LeaderBoardCanvas;
    public AudioSource MenuSrc;
    public AudioClip MenuClip;
    private void Awake()
    {
        Time.timeScale = 1;
        GameManager.totalScore = 0;
    }

    // Update is called once per frame
    void Start()
    {
        MenuSrc.Play();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }    

    public void Leaderboard()
    {
        SceneManager.LoadScene(2);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
