using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableUsed : MonoBehaviour
{
    public AudioSource interact;

    void OnTriggerEnter(Collider other)
    {
        interact.Play();
        if (other.tag == "Character")
        {
            Debug.Log("Use Table");
        }
        
        
        //StartCoroutine(Score(other));
        //other.gameObject.SetActive(false);

    }

    IEnumerator Score(Collider i)
    {
        yield return new WaitForSeconds(0.1f);
        i.gameObject.SetActive(false);

    }
}

