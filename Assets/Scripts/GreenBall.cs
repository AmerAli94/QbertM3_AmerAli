using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : MonoBehaviour
{
    private Collider BallCol;
    //public Transform 
    // Start is called before the first frame update
    void Start()
    {
        BallCol = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
       // BallCol.isTrigger = true;

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

        if(other.gameObject.tag == "Qbert")
        {
            Destroy(gameObject);
        }

    }
}
