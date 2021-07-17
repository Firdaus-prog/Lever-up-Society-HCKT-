using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMenuAnimation : MonoBehaviour
{
    public GameObject panelMenu;

    public void ShowHideMenu()
    {
        if(panelMenu != null)
        {
            Animator animator = panelMenu.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
        }
    }
}
