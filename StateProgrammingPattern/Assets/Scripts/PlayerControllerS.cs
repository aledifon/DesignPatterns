using UnityEngine;

public class PlayerControllerS : MonoBehaviour
{
    public bool IsGrounded {  get; private set; }
    public StateMachine playerStateMachine {  get; private set; }

    private void Awake()
    {
        // Create a Statemachine instance
        playerStateMachine = new StateMachine(this);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsGrounded = true;
        playerStateMachine.Initialize(playerStateMachine.idleState);
    }

    // Update is called once per frame
    void Update()
    {
        playerStateMachine.Update();

        if(Input.GetMouseButtonDown(0)) IsGrounded = !IsGrounded;
    }
}
