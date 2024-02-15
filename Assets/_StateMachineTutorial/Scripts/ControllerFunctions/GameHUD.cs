using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHUD : MonoBehaviour
{

    private GameObject currentChild = null;

    public void ActivateChild(int childIndex)
    {
        currentChild = this.gameObject.transform.GetChild(childIndex).gameObject;

        currentChild.SetActive(true);

    }

    public void DeactivateChild(int childIndex)
    {
        currentChild = this.gameObject.transform.GetChild(childIndex).gameObject;

        currentChild.SetActive(false);

    }
}
