using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int _roomNum = 1;

    public void ActivateChild(int childIndex)
    {
        GameObject currentChild = this.gameObject.transform.GetChild(childIndex).gameObject;

        currentChild.SetActive(true);

    }

    public void DeactivateChild(int childIndex)
    {
        GameObject currentChild = this.gameObject.transform.GetChild(childIndex).gameObject;

        currentChild.SetActive(false);

    }

    public void MonsterCheck()
    {

    }

    public void MonsterMove(int roomNumber)
    {
        _roomNum = roomNumber;

        switch (_roomNum)
        {
            case 1:
                ActivateChild(0);
                DeactivateChild(1);
                DeactivateChild(4);
                DeactivateChild(6);
                break;
            case 2:
                ActivateChild(1);
                DeactivateChild(0);
                DeactivateChild(2);
                break;
            case 3:
                ActivateChild(2);
                DeactivateChild(1);
                DeactivateChild(3);
                DeactivateChild(5);
                DeactivateChild(7);
                break;
            case 4:
                ActivateChild(3);
                DeactivateChild(2);
                DeactivateChild(6);
                break;
            case 5:
                ActivateChild(4);
                DeactivateChild(0);
                DeactivateChild(7);
                break;
            case 6:
                ActivateChild(5);
                DeactivateChild(2);
                break;
            case 7:
                ActivateChild(6);
                DeactivateChild(0);
                DeactivateChild(3);
                break;
            case 8:
                ActivateChild(7);
                DeactivateChild(4);
                DeactivateChild(2);
                break;
        }

    }
}
