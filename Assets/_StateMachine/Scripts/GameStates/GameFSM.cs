using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameController))]
public class GameFSM : StateMachineMB
{
    private GameController _controller;

    //variables
    public GameSetupState SetupState { get; private set; }
    public GamePlayState PlayState { get; private set; }
    public PlayerTurnMainState PlayerTurn { get; private set; }
    public PlayerTurnMoveState PlayerMove { get; private set; }
    public EnemyTurnState EnemyTurn { get; private set; }
    public WinState WinState { get; private set; }
    public LoseState LoseState { get; private set; }

    private void Awake()
    {
        _controller = GetComponent<GameController>();
        //instantiate
        SetupState = new GameSetupState(this, _controller);
        PlayState = new GamePlayState(this, _controller);
        PlayerTurn = new PlayerTurnMainState(this, _controller);
        PlayerMove = new PlayerTurnMoveState(this, _controller);
        EnemyTurn = new EnemyTurnState(this, _controller);
        WinState = new WinState(this, _controller);
        LoseState = new LoseState(this, _controller);
    }

    private void Start()
    {
        ChangeState(SetupState);
    }
}
