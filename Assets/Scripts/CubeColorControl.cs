using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorControl : MonoBehaviour
{
    public Material ChangeToMaterial;
    private int CubeColor = 1;
    public AudioSource HopSound;
    public AudioClip HopClip;
    public AudioClip HopClip2;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Qbert")
        {
                    
        CubeColor -= 1;
            if (CubeColor == 0)
            {
                GetComponent<Renderer>().material = ChangeToMaterial;
                GameManager.remainingCubes -= 1;
                GameManager.totalScore += 25;
                HopSound.clip = HopClip;
                HopSound.Play();
            }
            else
            {
                HopSound.clip = HopClip2;
                HopSound.Play();
            }
        }
    }
}
