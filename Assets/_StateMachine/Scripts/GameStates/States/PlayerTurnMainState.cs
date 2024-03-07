using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnMainState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    private bool _releaseReady;

    public PlayerTurnMainState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("START: Main");
        _controller.HUD.ActivateChild(0);
        _controller.HUD.DeactivateChild(1);
        _controller.HUD.ActivateChild(4);
        _controller.HUD.ActivateChild(5);
        _controller.HUD.ActivateChild(10);
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("END: Main");
        _controller.HUD.DeactivateChild(4);
        _controller.HUD.DeactivateChild(5);
        _controller.HUD.DeactivateChild(10);
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        base.Tick();

        if (_controller.ActionCounter._actions <= 0)
        {
            _stateMachine.ChangeState(_stateMachine.EnemyTurn);
        }

        if (_controller.TurnCounter._turn > 5)
        {
            _stateMachine.ChangeState(_stateMachine.WinState);
        }
    }
}
