using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacementController : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField]
    public GameObject placeableLamp;
    public GameObject placeableBed;
    public GameObject placeableDresser;
    public GameObject placeableClock;

    //[SerializeField]
    public KeyCode LampObjectHotKey = KeyCode.G;
    [SerializeField]
    private KeyCode BedObjectHotKey = KeyCode.H;
    [SerializeField]
    private KeyCode CabinetObjectHotKey = KeyCode.K;
    [SerializeField]
    private KeyCode ClockObjectHotKey = KeyCode.L;

    private GameObject currentPlaceableObject;

    private float mouseWheelRotation;
    void Update()
    {
        HandleNewObjectHotKey();

        if (currentPlaceableObject != null)
        {
            MoveCurrentObjectToMouse();
            RotateFromMouseWheel();
            ReleaseIfClicked();
        }
    }

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
                currentPlaceableObject = Instantiate(placeableClock);
            }
        }
    }

    private void MoveCurrentObjectToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            currentPlaceableObject.transform.position = hitInfo.point;
            currentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
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
}
