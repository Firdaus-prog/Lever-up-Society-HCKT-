using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAll : MonoBehaviour
{
    public GameObject hiddenObj;
    public bool control = false;

    public void ShowObj()
    {
        hiddenObj.SetActive(control);
        control = !control;
    }
}
