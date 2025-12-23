using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum PlayerControllerState
    {
        Idle,
        Walk,
        Jump
    }

    private PlayerControllerState state;

    // Update is called once per frame
    void Update()
    {
        GetInput();

        switch (state)
        {
            case PlayerControllerState.Idle:
                Idle();
                break;
            case PlayerControllerState.Walk:
                Walk();
                break;
            case PlayerControllerState.Jump:
                Jump();
                break;
        }
    }
     
    private void GetInput()
    {
        //Input
    }
    private void Idle()
    {
        //Idle
    }
    private void Walk()
    {
        //Walk
    }
    private void Jump()
    {
        //Jump
    }
}
