using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacementController : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField]
    public GameObject placeableLamp, placeableBed, placeableDresser, placeableToilet, placebleSink, placebalNightStand;
    public int priceLamp = 50;
    public int priceBed = 200;
    public int priceDresser = 180;
    public int priceToilet = 80;
    public int priceSink = 80;
    public int priceNightStand = 150;
    


    private GameObject currentPlaceableObject;

    private float mouseWheelRotation;
    void Update()
    {
        //HandleNewObjectHotKey();

        if (currentPlaceableObject != null)
        {
            MoveCurrentObjectToMouse();
            RotateFromMouseWheel();
            ReleaseIfClicked();
        }
    }

    /*
    private void HandleNewObjectHotKey()
    {
        if (Input.GetKeyDown(LampObjectHotKey))
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            else
            {
                currentPlaceableObject = Instantiate(placeableLamp);
            }
        }

        else if (Input.GetKeyDown(BedObjectHotKey))
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            else
            {
                currentPlaceableObject = Instantiate(placeableBed);
            }
        }

        else if (Input.GetKeyDown(CabinetObjectHotKey))
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            else
            {
                currentPlaceableObject = Instantiate(placeableDresser);
            }
        }

        else if (Input.GetKeyDown(ClockObjectHotKey))
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            else
            {
                currentPlaceableObject = Instantiate(placeableToilet);
            }
        }
    }
    */

    private void MoveCurrentObjectToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            currentPlaceableObject.transform.position = hitInfo.point;
            currentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
            Debug.DrawRay(transform.position, transform.forward, Color.green);
            print("Hit");
        }
    }

    private void RotateFromMouseWheel()
    {
        Debug.Log(Input.mouseScrollDelta);
        mouseWheelRotation += Input.mouseScrollDelta.y;
        currentPlaceableObject.transform.Rotate(Vector3.up, mouseWheelRotation * 10f);
    }

    private void ReleaseIfClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentPlaceableObject = null;
        }
    }

    public void BuyLamp()
    {
        if (Global_Value.moneyValue >= priceLamp)
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            
            currentPlaceableObject = Instantiate(placeableLamp);
            Global_Value.moneyValue -= priceLamp;
            
        }
    }

    public void BuyBed()
    {
        if (Global_Value.moneyValue >= priceBed)
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            
            currentPlaceableObject = Instantiate(placeableBed);
            Global_Value.moneyValue -= priceBed;
            
        }
    }

    public void BuyDresser()
    {
        if (Global_Value.moneyValue >= priceDresser)
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            
            currentPlaceableObject = Instantiate(placeableDresser);
            Global_Value.moneyValue -= priceDresser;
            
        }
    }

    public void BuyToilet()
    {
        if (Global_Value.moneyValue >= priceToilet)
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            
            currentPlaceableObject = Instantiate(placeableToilet);
            Global_Value.moneyValue -= priceToilet;
            
        }
    }

    public void BuySink()
    {
        if (Global_Value.moneyValue >= priceSink)
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            
            currentPlaceableObject = Instantiate(placebleSink);
            Global_Value.moneyValue -= priceSink;
            
        }
    }

    public void BuyNightStand()
    {
        if (Global_Value.moneyValue >= priceNightStand)
        {
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            
            currentPlaceableObject = Instantiate(placebalNightStand);
            Global_Value.moneyValue -= priceNightStand;
            
        }
    }

}
