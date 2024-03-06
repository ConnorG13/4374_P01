using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnMoveState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    private bool _releaseReady = false;

    public PlayerTurnMoveState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("START: Move");

        _controller.HUD.ActivateChild(6);
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("END: Move");

        _controller.HUD.DeactivateChild(6);
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        base.Tick();
        
        if (_controller.Input.IsTapPressed == true)
        {
            _releaseReady = true;
        }

        if (_controller.Input.IsTapPressed == false && _releaseReady == true)
        {
            _controller.ActionCounter._actions -= 1;
            _stateMachine.ChangeStateToPrevious();
            _releaseReady = false;
        }
        

    }
}
