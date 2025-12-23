using UnityEngine;

public class WalkState : IState
{
    private PlayerControllerS player;

    //Class constructor
    public WalkState(PlayerControllerS player)
    {
        this.player = player;
    }
    public void Enter()
    {
        Debug.Log("Enter Walk State");
    }
    public void Update()
    {
        Debug.Log("Update Walk State");
    }
    public void Exit()
    {
        Debug.Log("Exit Walk State");
    }
}
