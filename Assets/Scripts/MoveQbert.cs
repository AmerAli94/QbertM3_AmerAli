using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveQbert : MonoBehaviour
{
    public bool IsJumping = false;

    public GameObject RedBall;
    private Rigidbody Rb;

    // Update is called once per frame
    void Update()
    {

        //Bottom Left Movement
        if (Input.GetKeyDown("[1]") && IsJumping == false)
        {
            IsJumping = true;
            transform.eulerAngles = new Vector3(0, 180, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }
        //Bottom Right
        if (Input.GetKeyDown("[3]") && IsJumping == false)
        {
            IsJumping = true;
            transform.eulerAngles = new Vector3(0, 90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }
        //Top Left
        if (Input.GetKeyDown("[7]") && IsJumping == false)
        {
            IsJumping = true;
            transform.eulerAngles = new Vector3(0, 270, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        }
        //Top Right
        if (Input.GetKeyDown("[9]") && IsJumping == false)
        {
            IsJumping = true;
            transform.eulerAngles = new Vector3(0, 0, 0);

            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }
 
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Planes")
        {
            StartCoroutine(delayInput());

        }
        if (col.gameObject.tag == "LastPlanes")
        {
            StartCoroutine(delayInput());

        }
        if (col.gameObject.tag == "RedBall" )
        {
            GameManager.HasCollided = "Yes";
            GameManager.remainingLives -= 1;
            GetComponent<Transform>().position = new Vector3(0, 0.49f, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        if  (col.gameObject.tag == "PurpleBall")
        {
            GameManager.HasCollided = "Yes";
            GameManager.remainingLives -= 1;
            GetComponent<Transform>().position = new Vector3(0, 0.49f, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }

        if (col.gameObject.tag == "GreenBall")
        {
            GameManager.totalScore += 100;
            Rb.isKinematic = true;
        }
        else
        {
            Rb.isKinematic = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ResetCollider")
        {
            GetComponent<Transform>().position = new Vector3(0, 0.49f, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            transform.eulerAngles = new Vector3(0, 180, 0);
            GameManager.remainingLives -= 1;
            Debug.Log(GameManager.remainingLives);
            StartCoroutine(delayRespawn());

        }

        if (other.tag == "ElevatorTrigger")
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1.15f);

        }

        if (other.tag == "ElevatorLeftTrigger")
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1.2f, 4, 0);

        }

        
      

    }

    IEnumerator delayInput()
    {
        yield return new WaitForSeconds(0.04f);
        IsJumping = false;

    }

    IEnumerator delayRespawn()
    {
        yield return new WaitForSeconds(0.1f);
        GameManager.HasCollided = "Yes";
    }

}
