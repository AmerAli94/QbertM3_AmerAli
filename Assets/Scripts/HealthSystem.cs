using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    public GameObject[] health;
    public int life;

    void Update()
    {
        if (life < 1)
        {
            Destroy(health[0].gameObject);
        }
        else if (life < 2)
        {
            Destroy(health[0].gameObject);
        }
        else if (life < 3)
        {
            Destroy(health[0].gameObject);
        }
    }

    public void TakeDamage(int d)
    {
        life -= d;
    }
}
