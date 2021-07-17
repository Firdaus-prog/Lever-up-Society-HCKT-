using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickTutorial : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button ScheduleButton;

    [SerializeField]
    private GameObject SchedulePanel;

    [SerializeField]
    

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        ScheduleButton.onClick.AddListener(CreateAnEmptyPlanner);
    }

    void CreateAnEmptyPlanner()
    {
        //Output this to console when Button1 or Button3 is clicked
        
    }
}

