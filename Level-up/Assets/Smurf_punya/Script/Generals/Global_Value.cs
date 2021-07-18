using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global_Value : MonoBehaviour
{
    public static int moneyValue = 500; 
    public static int expValue = 0;
    public static int lvlValue = 1;
    public static int dzValue = 0;

    public Text moneyText, dzText, lvlText;


    void Update()
    {
        moneyText.text = moneyValue.ToString();
        dzText.text = dzValue.ToString();
        lvlText.text = lvlValue.ToString();
    }
}
