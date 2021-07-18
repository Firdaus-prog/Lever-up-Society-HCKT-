using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private InventorySlot inventory;
    public GameObject itemButton;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySlot>();
    }

    void OnTriggerEnter3D(Collider2D other)
    {
        Debug.Log("I am here");

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player colliding");
            Debug.Log(inventory.slots.Length);

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //inventory.isFull[i] == true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }

}
