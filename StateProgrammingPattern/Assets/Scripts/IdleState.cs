using UnityEngine;

public class IdleState : IState
{
    private PlayerControllerS player;

    //Class constructor
    public IdleState(PlayerControllerS player)
    {
        this.player = player;
    }
    public void Enter()
    {
        Debug.Log("Enter Idle State");
    }
    public void Update()
    {
        Debug.Log("Update Idle State");
        if(!player.IsGrounded)
        {
            player.playerStateMachine.TransitionTo(player.playerStateMachine.jumpState);
        }
    }
    public void Exit()
    {
        Debug.Log("Exit Idle State");
    }
}
