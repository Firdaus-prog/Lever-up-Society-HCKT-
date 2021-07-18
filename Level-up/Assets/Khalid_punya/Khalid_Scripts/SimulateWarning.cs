using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulateWarning : MonoBehaviour
{
    public GameObject Panel;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Panel.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Panel.gameObject.SetActive(true);
        }
    }
    
}
