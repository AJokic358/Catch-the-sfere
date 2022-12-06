using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCMBegins : MonoBehaviour
{
    public GameObject mainLogo;
    public GameObject[] menuText;
    public GameObject splashBackground;
    public GameObject BGM;
    public GameObject globalScripts;
    public GameObject countdownText;
    public GameObject tapButton;
    public GameObject[] finalText;
    public GameObject slider;
    public GameObject pause;
    public GameObject resume;
    public GameObject quit;

    void Start()
    {
        StartCoroutine(StartUpGame());
    }

    IEnumerator StartUpGame()
    {
        yield return new WaitForSeconds(1);
        mainLogo.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        mainLogo.SetActive(false);
        menuText[0].SetActive(true);
        menuText[1].SetActive(true);
        menuText[2].SetActive(true);
        menuText[3].SetActive(true);
        tapButton.SetActive(true);
        slider.SetActive(true);
        quit.SetActive(true);

    }

    public void TapToStart()
    {
        tapButton.SetActive(false);
        menuText[0].SetActive(false);
        menuText[1].SetActive(false);
        menuText[2].SetActive(false);
        menuText[3].SetActive(false);
        slider.SetActive(false);
        quit.SetActive(false);
        splashBackground.GetComponent<Animator>().Play("SplashFadeOut");
        StartCoroutine(BeginTheGame());
        pause.SetActive(true);
        resume.SetActive(true);
    }

    IEnumerator BeginTheGame()
    {
        finalText[0].SetActive(false);
        finalText[1].SetActive(false);
        yield return new WaitForSeconds(1);
        countdownText.SetActive(true);
        yield return new WaitForSeconds(1);
        countdownText.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1);
        countdownText.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1);
        countdownText.SetActive(false);
        countdownText.GetComponent<Text>().text = "3";
        BGM.SetActive(true);
        splashBackground.SetActive(false);
        globalScripts.GetComponent<Timer>().enabled = true;
        globalScripts.GetComponent<SphereGenerate>().enabled = true;
    }
}//class
