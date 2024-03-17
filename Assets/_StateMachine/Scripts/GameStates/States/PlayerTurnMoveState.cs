using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnMoveState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

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
        _controller.UnitMover.CheckAvailableRooms();
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("END: Move");

        _controller.ActionCounter._actions -= 1;
        _controller.HUD.DeactivateChild(6);
        _controller.UnitMover.ReactivateRooms();
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        base.Tick();
    }
}
