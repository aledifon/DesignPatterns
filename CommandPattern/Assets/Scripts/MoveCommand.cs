using UnityEngine;

public class MoveCommand : ICommand
{
    private PlayerMovement playerMovement;
    private Vector3 movement;

    public MoveCommand(PlayerMovement playerMovement, Vector3 movement)
    {
        this.playerMovement = playerMovement;
        this.movement = movement;
    }
    public void Execute()
    {
        playerMovement.Move(movement);
    }
    public void Undo()
    {
        playerMovement.Move(-movement);
    }
}
