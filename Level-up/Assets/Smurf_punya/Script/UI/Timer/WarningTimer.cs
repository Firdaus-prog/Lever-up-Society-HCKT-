using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WarningTimer : MonoBehaviour
{
    public float timeValue = 90;
    public float timetoWait = 5;
    public float returnTimeToRoom = 3;
    public Text timeText;
    public GameObject Panel;
    void Start()
    {
        //Panel.gameObject.SetActive(false);
    }

    void Update()
    {
        timetoWait -= Time.deltaTime;
        //Debug.Log(timetoWait);

        if (timetoWait < 0)
        {
            Panel.gameObject.SetActive(true);

            if(timeValue > 0)
            {
            timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;

                if (returnTimeToRoom > 0)
                {
                    returnTimeToRoom -= Time.deltaTime;
                    Debug.Log(returnTimeToRoom);
                }
                else if (returnTimeToRoom < 0)
                {
                    returnTimeToRoom = 0;
                    SceneManager.LoadScene(1);
                }
            }

            DisplayTime(timeValue);
        }
    }

    void DisplayTime(float timeToDisplay)
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
}
