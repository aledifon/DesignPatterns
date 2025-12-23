using System;
using UnityEngine;

public class StateMachine
{
    public IState currentState {  get; private set; }

    //refs. to the States
    public WalkState walkState;
    public IdleState idleState;
    public JumpState jumpState;

    // Event to notify other objects the player state has changed
    public event Action<IState> StateChanged;

    // class constructor
    public StateMachine(PlayerControllerS player)
    {
        //create an instance for every state
        this.idleState = new IdleState(player);
        this.walkState = new WalkState(player);
        this.jumpState = new JumpState(player);
    }

    //Establish the init state
    public void Initialize(IState state)
    {
        currentState = state;
        state.Enter();

        StateChanged?.Invoke(currentState);
    }

    // Transition from one state to another one
    public void TransitionTo(IState nextState)
    {
        currentState.Exit();
        currentState = nextState;
        currentState.Enter();

        StateChanged?.Invoke(currentState);
    }

    // State update
    public void Update()
    {
        if(currentState != null) currentState.Update();
    }
}
