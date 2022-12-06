using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereCatch : MonoBehaviour
{
    public AudioSource sphereCatchFX;
    private void OnTriggerEnter(Collider other)
    {
        sphereCatchFX.Play();
        if (other.tag == "BlueSphere")
        {
            ScoreUpdater.sphereScore += 1;
            
        }
        if (other.tag == "GreenSphere")
        {
            ScoreUpdater.sphereScore += 2;
        }
        if (other.tag == "RedSphere")
        {
            ScoreUpdater.sphereScore += 3;
        }
        ScoreUpdater.sphereCount += 1;
        other.gameObject.SetActive(false);
    }

}//class
