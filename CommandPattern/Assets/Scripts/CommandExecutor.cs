using UnityEngine;
using System;
using System.Collections.Generic;

public class CommandExecuter : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    private Stack<ICommand> undoStack = new Stack<ICommand>();
    private Stack<ICommand> redoStack = new Stack<ICommand>();    
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            ExecuteCommand(new MoveCommand(playerMovement,Vector3.up));
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            ExecuteCommand(new MoveCommand(playerMovement,Vector3.down));
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            ExecuteCommand(new MoveCommand(playerMovement,Vector3.left));
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            ExecuteCommand(new MoveCommand(playerMovement,Vector3.right));
    }
    void ExecuteCommand(ICommand command)
    {
        command.Execute();
        // Add the executed command to the undoStack in case we want to undo it
        undoStack.Push(command);
        // Every time a new action is executed the redoStack is cleared.
        redoStack.Clear();
    }
    public void UndoCommand()
    {
        if(undoStack.Count == 0) 
            return;

        // Get the most recent command from the undoStack
        // and push also the same one on the redoStack
        ICommand currentCommand = undoStack.Pop();
        redoStack.Push(currentCommand);
        // Finally undo the current Command (Execute it on reversed way)
        currentCommand.Undo();
    }
    public void RedoCommand()
    {
        if(redoStack.Count == 0)
            return;

        // Get the most recent command from the redoStack
        // and push also the same one on the undoStack
        ICommand currentCommand = redoStack.Pop();
        undoStack.Push(currentCommand);
        // Finally execute the current Command
        currentCommand.Execute();
    }
}
