using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainTimer : MonoBehaviour
{
    public float timeValue = 5;
    public static float setTime = 5;
    public Text timeText, moneyReward, expReward;
    public Animator transitionPanel, transitionScene;
    public bool timeControl = true;
    public float transitionTime = 0.8f;
    public int moneyGain, expGain;

    void Start()
    {
        //Random  rnd = new Random();
        moneyGain  = Random.Range(1, 15);
        expGain  = Random.Range(10, 50);
        moneyReward.text = "+ " + moneyGain + " Coin";
        expReward.text = "+ " + expGain + " Exp";
    }



    void Update()
    {
        if(timeValue > 0)
        {
          timeValue -= Time.deltaTime;
        }
        else if(timeControl)
        {
            timeValue = 0;
        }

        if(timeValue == 0)
        {
            if(timeControl)
            {
                transitionPanel.SetTrigger("EndTime");
                Debug.Log("time end");
                timeControl = false;
                timeValue = setTime;
            }
        }

        DisplayTime(timeValue);
    }

    public void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);//will round down value
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        //float milliseconds = timeToDisplay % 1 * 1000;

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void ExitTimer()
    {
        Global_Value.expValue += expGain;
        Global_Value.moneyValue += moneyGain;
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 2));
    }
   
    IEnumerator LoadScene(int levelIndex)
    {
        //Play animation
        transitionScene.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load Scene
        SceneManager.LoadScene(levelIndex);
    }

}
