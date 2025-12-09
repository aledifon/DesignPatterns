using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CommandManager : MonoBehaviour
{
    private Queue<string> commands = new Queue<string>();
    [SerializeField] private TMP_Text commandsText;

    public void AddCommand(string command) 
    {
        commands.Enqueue(command);

        UpdateQueueCommandsText();
    }
    public void RunNextCommand() 
    {
        if (commands.Count == 0) return;        

        string cmd = commands.Dequeue();
        Debug.Log(cmd);

        UpdateQueueCommandsText();
    }

    void UpdateQueueCommandsText()
    {
        commandsText.text = string.Empty;


        foreach(string command in commands)
        {
            commandsText.text += command + ", ";
        }

    }
}
