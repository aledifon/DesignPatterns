using UnityEngine;

public class JumpState : IState
{
    private PlayerControllerS player;

    //Class constructor
    public JumpState(PlayerControllerS player)
    {
        this.player = player;
    }
    public void Enter()
    {
        Debug.Log("Enter Jump State");
    }
    public void Update()
    {
        Debug.Log("Update Jump State");
        if (player.IsGrounded)
        {
            player.playerStateMachine.TransitionTo(player.playerStateMachine.idleState);
        }
    }
    public void Exit()
    {
        Debug.Log("Exit Jump State");
    }
}
