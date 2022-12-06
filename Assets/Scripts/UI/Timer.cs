using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool countingDown = false;
    public int currentSeconds = 30;
    public bool isZero = false;
    public GameObject splashBacground;
    public GameObject BGM;
    public GameObject globalScripts;
    public GameObject tapPlayButton;
    public GameObject finalScore;
    public GameObject finalSpheres;
    public GameObject tapToBeginText;
    public GameObject pauseS;
    public GameObject resumeS;
    

    void Update()
    {
        if(countingDown == false && isZero == false)
        {
            countingDown = true;
            StartCoroutine(SubtractSecond());
        }
        if(isZero == true)
        {
            finalScore.GetComponent<Text>().text = "SCORE: " + ScoreUpdater.sphereScore;
            finalSpheres.GetComponent<Text>().text = "SPHERES: " + ScoreUpdater.sphereCount;
            StartCoroutine(GameOver());
        }
    }

    IEnumerator SubtractSecond()
    {
        yield return new WaitForSeconds(1);
        currentSeconds -= 1;
        if(currentSeconds == 0)
        {
            isZero = true;
        }
        timeDisplay.GetComponent<Text>().text = "TIME: " + currentSeconds;
        countingDown = false;
    }

    IEnumerator GameOver()
    {
        pauseS.SetActive(false);
        resumeS.SetActive(false);
        splashBacground.SetActive(true);
        splashBacground.GetComponent<Animator>().Play("SplashFadeIn");
        BGM.SetActive(false);
        globalScripts.GetComponent<SphereGenerate>().enabled = false;
        yield return new WaitForSeconds(1.2f);       
        finalScore.SetActive(true);
        finalSpheres.SetActive(true);
        tapToBeginText.SetActive(true);
        tapPlayButton.SetActive(true);
        currentSeconds = 31;
        isZero = false;
        ScoreUpdater.sphereCount = 0;
        ScoreUpdater.sphereScore = 0;
        yield return new WaitForSeconds(0.1f);
        globalScripts.GetComponent<Timer>().enabled = false;
    }
}//class
