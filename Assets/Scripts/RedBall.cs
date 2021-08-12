using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : MonoBehaviour
{
  

    void Update()
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        //if (GameManager.HasCollided == "Yes")
        //{
        //    Destroy(gameObject);
        //}
    }
    private void OnCollisionEnter(Collision other)
    {
        if (Random.Range(0, 2) == 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, -1);

        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, 5, 0);

        }
    }
}
