using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharInteract : MonoBehaviour
{
    //public AudioSource interact;
    public GameObject tableButton, bedButton;
    public Collider mainBody;

    void OnTriggerEnter(Collider other)
    {
        //interact.Play();
        if (other.tag == "Table")
        {
            Debug.Log("Use Table");
            ShowButton(tableButton);
        }
        else if(other.tag == "Bed")
        {
            Debug.Log("Use Bed");
            ShowButton(bedButton);
        }
        else  if(other.tag == "Outside")
        {
            Debug.Log("OutSide");
            CloseButton(tableButton);
            CloseButton(bedButton);
        }
        
    }

    public void ShowButton(GameObject button)
    {
        if(button != null)
        {
            Animator animator = button.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
        }
    }

    public void CloseButton(GameObject button)
    {
        if(button != null)
        {
            Animator animator = button.GetComponent<Animator>();
            if(animator != null)
            {
                animator.SetBool("show", true);
            }
        }
    }

    void Start()
    {
        CloseButton(tableButton);
        

    }


}
