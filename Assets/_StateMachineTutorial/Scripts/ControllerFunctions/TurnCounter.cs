using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnCounter : MonoBehaviour
{
    public int _turn = 1;
    private TMP_Text _turnCounter;

    private void Awake()
    {
        _turnCounter = this.GetComponent<TMP_Text>();
    }

    private void Update()
    {
        _turnCounter.SetText("Turn: " + _turn);
    }
}
