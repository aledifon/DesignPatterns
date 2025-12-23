public interface IState
{
    public void Enter()
    {
        // Executed code when we enter to the state
    }
    public void Update()
    {
        // Executed code every frame while the state is active
    }
    public void Exit()
    {
        // Executed code when we exit from the state
    }
}
