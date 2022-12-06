using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public static int sphereScore;
    public static int sphereCount;
    public GameObject scoreDisplay;
    public GameObject sphereDisplay;
    private void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "SCORE: " + sphereScore;
        sphereDisplay.GetComponent<Text>().text = "SPHERES: " + sphereCount;
    }

}//class
