using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateNavigation : MonoBehaviour
{
    [SerializeField] private GameFSM _stateMachine;

    public StateNavigation(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
    }

    public void ProceedToMove()
    {
        _stateMachine.ChangeState(_stateMachine.PlayerMove);
    }

    public void ProceedToMain()
    {
        _stateMachine.ChangeState(_stateMachine.PlayerTurn);
    }
}
