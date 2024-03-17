using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitMover : MonoBehaviour
{
    private GameObject currentChild = null;
    [SerializeField] private Unit unitScript;
    [SerializeField] GameObject _roomHolder;

    public void ActivateChild(int childIndex)
    {
        currentChild = _roomHolder.gameObject.transform.GetChild(childIndex).gameObject;

        currentChild.SetActive(true);

    }
    public void DeactivateChild(int childIndex)
    {
        currentChild = _roomHolder.gameObject.transform.GetChild(childIndex).gameObject;

        currentChild.SetActive(false);

    }
    public void ActivateChildButton(int childIndex)
    {
        currentChild = _roomHolder.gameObject.transform.GetChild(childIndex).gameObject;
        Button childButton = currentChild.GetComponent<Button>();

        childButton.enabled = true;
    }
    public void DeactivateChildButton(int childIndex)
    {
        currentChild = _roomHolder.gameObject.transform.GetChild(childIndex).gameObject;
        Button childButton = currentChild.GetComponent<Button>();

        childButton.enabled = false;
    }

    public void CheckAvailableRooms()
    {
        switch (unitScript._roomNum)
        {
            case 1:
                DeactivateChild(2);
                DeactivateChild(3);
                DeactivateChild(5);
                ActivateChildButton(1);
                ActivateChildButton(4);
                break;
            case 2:
                DeactivateChild(3);
                DeactivateChild(4);
                DeactivateChild(5);
                ActivateChildButton(0);
                ActivateChildButton(2);
                break;
            case 3:
                DeactivateChild(0);
                DeactivateChild(4);
                ActivateChildButton(1);
                ActivateChildButton(3);
                ActivateChildButton(5);
                break;
            case 4:
                DeactivateChild(0);
                DeactivateChild(1);
                DeactivateChild(4);
                DeactivateChild(5);
                ActivateChildButton(2);
                break;
            case 5:
                DeactivateChild(1);
                DeactivateChild(2);
                DeactivateChild(3);
                DeactivateChild(5);
                ActivateChildButton(0);
                break;
            case 6:
                DeactivateChild(0);
                DeactivateChild(1);
                DeactivateChild(3);
                DeactivateChild(4);
                ActivateChildButton(2);
                break;
        }
    }

    public void ReactivateRooms()
    {
        ActivateChild(0);
        ActivateChild(1);
        ActivateChild(2);
        ActivateChild(3);
        ActivateChild(4);
        ActivateChild(5);
    }

}
