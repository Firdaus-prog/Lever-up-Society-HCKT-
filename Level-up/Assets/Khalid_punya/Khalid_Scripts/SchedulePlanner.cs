using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchedulePlanner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject placeableSchedulePanel;

    [SerializeField]
    private KeyCode newObjectHotKey = KeyCode.Mouse1;

    private GameObject currentPlaceablePanel;

    void Update()
    {
        HandleNewObjectHotKey();

        if (currentPlaceablePanel != null)
        {
            MoveCurrentObjectToMouse();
            ReleaseIfClicked();
        }
    }

    private void HandleNewObjectHotKey()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (currentPlaceablePanel != null)
            {
                Destroy(currentPlaceablePanel);
            }
            else
            {
                currentPlaceablePanel = Instantiate(placeableSchedulePanel);
            }
        }
    }

    private void MoveCurrentObjectToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            currentPlaceablePanel.transform.position = hitInfo.point;
            currentPlaceablePanel.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }

    private void ReleaseIfClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentPlaceablePanel = null;
        }
    }
}

