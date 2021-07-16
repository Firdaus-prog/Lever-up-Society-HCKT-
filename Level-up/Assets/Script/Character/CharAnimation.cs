using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimation : MonoBehaviour
{
    public GameObject mainChar;
    void Start()
    {
        mainChar.GetComponent<Animation>().Play("Idle");
    }


    void Update()
    {
        
    }
}
