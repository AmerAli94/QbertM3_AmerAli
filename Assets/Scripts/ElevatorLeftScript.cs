using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorLeftScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Qbert")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 7, 4);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }


}

