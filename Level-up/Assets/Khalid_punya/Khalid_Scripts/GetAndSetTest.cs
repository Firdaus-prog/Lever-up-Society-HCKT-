using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAndSetTest : MonoBehaviour
{
    int num_plan = 0;
    List<string> allPlans = new List<string>();
    string input_text1, input_text2, input_text3, input_text4;
    public InputField SchedulePlan;

    public Text Plan1, Plan2, Plan3, Plan4;

    // Start is called before the first frame update
    public void setget()
    {

        if (num_plan == 0)
            Plan1.text = SchedulePlan.text;
        if (num_plan == 1)
            Plan2.text = SchedulePlan.text;
        else if (num_plan == 2)
            Plan3.text =  SchedulePlan.text;
        else if (num_plan == 3)
            Plan4.text =  SchedulePlan.text;

        num_plan++;

        SchedulePlan.Select();
        SchedulePlan.text = "";
        
    }

}

