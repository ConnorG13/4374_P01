using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public WinState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("START: Win!");

        _controller.HUD.DeactivateChild(0);
        _controller.HUD.ActivateChild(2);
        _controller.HUD.DeactivateChild(5);
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("END: Win");
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
