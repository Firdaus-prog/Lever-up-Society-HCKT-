using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public GameObject mainLogo, splashBackground, bgm, introAudio, mainMenu;

    void Start()
    {
        StartCoroutine(StartupGame());
    }

    IEnumerator StartupGame()
    {
        yield return new WaitForSeconds(1);
        mainLogo.SetActive(true);
        yield return new WaitForSeconds(3f);
        mainLogo.SetActive(false);
        splashBackground.GetComponent<Animator>().Play("SplashFadeOut");
        bgm.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        introAudio.SetActive(false);
        splashBackground.SetActive(false);
        
        mainMenu.SetActive(true);
    }




}

