using System;
using UnityEngine;

public class PlayerControllerS_App
{
    public bool IsGrounded {  get; private set; }
    public StateMachine playerStateMachine {  get; private set; }
    
    public PlayerControllerS_App()
    {
        Awake();
    }
    // In order to make it work it should be adapted the PlayerControllerS_App ref everywhere
    private void Awake()
    {
        // Create a Statemachine instance 
        //playerStateMachine = new StateMachine(this);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        IsGrounded = true;
        playerStateMachine.Initialize(playerStateMachine.idleState);
    }

    // Update is called once per frame
    public void Update()
    {
        playerStateMachine.Update();

        if(Console.KeyAvailable) IsGrounded = !IsGrounded;
    }
}
