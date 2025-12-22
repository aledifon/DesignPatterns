using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private Light pointLight;

    private void OnEnable()
    {
        LightManager.Instance.OnTurnOn += TurnOn;           // Subscription
        LightManager.Instance.OnTurnOff += TurnOff;         
    }

    private void OnDisable()
    {
        LightManager.Instance.OnTurnOn -= TurnOn;           // Unsbuscription
        LightManager.Instance.OnTurnOff -= TurnOff;         
    }

    public void TurnOn() => pointLight.enabled = true;
    public void TurnOff() => pointLight.enabled = false;
}
