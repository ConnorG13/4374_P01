using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActionCounter : MonoBehaviour
{
    public int _actions = 3;
    private TMP_Text _actionCounter;

    private void Awake()
    {
        _actionCounter = this.GetComponent<TMP_Text>();
    }

    private void Update()
    {
        _actionCounter.SetText("Actions: " + _actions);
    }
}
