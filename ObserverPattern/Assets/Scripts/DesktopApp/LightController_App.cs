using System;
using UnityEngine;

public class LightController_App
{
    [SerializeField] private Light pointLight;

    public LightController_App()
    {
        Subscribe();
    }

    private void Subscribe()
    {
        LightManager_App.Instance.OnTurnOn += TurnOn;           // Subscription
        LightManager_App.Instance.OnTurnOff += TurnOff;         
    }

    private void Unsubscribe()
    {
        LightManager_App.Instance.OnTurnOn -= TurnOn;           // Unsbuscription
        LightManager_App.Instance.OnTurnOff -= TurnOff;         
    }

    public void TurnOn() 
    { 
        pointLight.enabled = true;
        Console.WriteLine("Light ON");
    }
    public void TurnOff() 
    {
        pointLight.enabled = false;
        Console.WriteLine("Light OFF");
    }

    // Equivalente a OnDisable / OnDestroy
    public void Dispose()
    {
        Unsubscribe();
    }
}
