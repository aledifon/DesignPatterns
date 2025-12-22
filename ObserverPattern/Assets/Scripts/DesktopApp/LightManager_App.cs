using System;

public class LightManager_App
{
    // The 'event' keyword declares the event, allows the subscriptions
    // 'Action' is a delegate, defines the event form
    // 'Action' is a simplified way of declaring delegates.
    public event Action OnTurnOn;
    public event Action OnTurnOff;

    // Singleton Pattern in order to allow the event subscrtiption        
    private static LightManager_App _instance;
    public static LightManager_App Instance =>  _instance ??= new LightManager_App(); 

    private LightManager_App()
    {
        Init();
    }

    private void Init()
    {
        // Init in case if needed
    }

    public void TurnOnAll()
    {        
        //? null-conditional operator (The Event will be invoked if it's not null)
        OnTurnOn?.Invoke();        
    }
    public void TurnOffAll()
    {        
        OnTurnOff?.Invoke();        
    }
}
