using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonBehaviour : MonoBehaviour
{
    int n;
    public void OnButtonPress()
    {
        n++;
        Debug.Log("Button Called " + n + " times");
    }
}
