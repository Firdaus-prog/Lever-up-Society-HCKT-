using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopControl : MonoBehaviour
{
    public GameObject shopMenu;
    public AudioSource slideSfx;

    public void SlideShop()
    {
        if(shopMenu != null)
        {
            Animator animator = shopMenu.GetComponent<Animator>();
            if(animator != null)
            {   slideSfx.Play();
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
        }
    }
}
