using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LeaderBoard : MonoBehaviour
{

    public AudioSource MenuSrc;
    public AudioClip MenuClip;

    // Start is called before the first frame update
    void Start()
    {
        MenuSrc.Play();
    }


    public void BackToMainButton()
    {
        SceneManager.LoadScene(0);
    }
}
