using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class GameManager : MonoBehaviour
{
    public static int remainingCubes = 28;

    public static int remainingLives = 3;
    public static string HasCollided = "NO";
    public static int totalScore = 0;
    public TextMeshProUGUI ScoreTXT;

    public GameObject[] health;
    //public int life;

    public Transform RedBall;
    public Transform GreenBall;
    public Transform PurpleBall;
    
   // public GameObject GameOverCanvas;

  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRedBall());
        StartCoroutine(SpawnGreenBall());
        StartCoroutine(SpawnPurpleBall());

        //GameOverCanvas.GetComponent<Canvas>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(remainingCubes == 0)
        {
            //Debug.Log("YOU WON");
            remainingLives = 4;
            StartCoroutine(loadLevel());
        }

        if(remainingCubes < 1)
        {
            AddScore(1000);
        }

        if (remainingLives < 1)
        {
            //GameOverCanvas.GetComponent<Canvas>().enabled = true;
            SceneManager.LoadScene(3);
            Destroy(health[0].gameObject);
            ResetLevel();

        }
        if (remainingLives == 1)
        {
            Destroy(health[1].gameObject);

        }
        else if (remainingLives == 2)
        {
            Destroy(health[2].gameObject);
        }
       

        ScoreTXT.text = totalScore.ToString();
        Debug.Log(remainingLives);
    }

    IEnumerator loadLevel()
    {
        yield return new WaitForSeconds(4);
        remainingCubes = 28;
        totalScore = 0;
        SceneManager.LoadScene(4);
    }

    IEnumerator SpawnRedBall()
    {
        Debug.Log("Red");
        yield return new WaitForSeconds(3);
        Instantiate(RedBall,new Vector3(0, 5, -1), RedBall.rotation);
        StartCoroutine(SpawnRedBall());
    }
    IEnumerator SpawnGreenBall()
    {
        Debug.Log("Green");

        yield return new WaitForSeconds(10);
        Instantiate(GreenBall, new Vector3(0, 5, -1), GreenBall.rotation);
        StartCoroutine(SpawnGreenBall());
    }

    IEnumerator SpawnPurpleBall()
    {
                Debug.Log("Red");

        yield return new WaitForSeconds(7);
        Instantiate(PurpleBall, new Vector3(0, 5, -1), PurpleBall.rotation);
        StartCoroutine(SpawnPurpleBall());
    }

    public void ResetLevel()
    {
        remainingCubes = 28;
        remainingLives = 3;
        HasCollided = "No";
        StartCoroutine(SpawnRedBall());
        StartCoroutine(SpawnGreenBall());
        StartCoroutine(SpawnPurpleBall());

    }

    public void TakeDamage(int d)
    {
        remainingLives -= d;
    }

    public void AddScore(int tot)
    {
      tot = totalScore + tot;
    }

}
