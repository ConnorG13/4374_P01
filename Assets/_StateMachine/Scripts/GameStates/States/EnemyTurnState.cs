using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public EnemyTurnState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("START: Enemy");

        _controller.HUD.DeactivateChild(0);
        _controller.HUD.ActivateChild(1);
        _controller.HUD.ActivateChild(7);
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("END: Enemy");

        _controller.HUD.DeactivateChild(7);

        _controller.ActionCounter._actions = 3;
        _controller.TurnCounter._turn += 1;
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        base.Tick();

        if(StateDuration >= _controller.TapLimitDuration)
        {
            _stateMachine.ChangeState(_stateMachine.PlayerTurn);
        }
    }
}
