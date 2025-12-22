using UnityEngine;
using System;

public class LightManager : MonoBehaviour
{
    // The 'event' keyword declares the event, allows the subscriptions
    // 'Action' is a delegate, defines the event form
    // 'Action' is a simplified way of declaring delegates.
    public event Action OnTurnOn;
    public event Action OnTurnOff;

    //[SerializeField] private LightController light1;
    //[SerializeField] private LightController light2;
    //[SerializeField] private LightController light3;

    // Singleton Pattern in order to allow the event subscrtiption    
    private static LightManager _instance;
    public static LightManager Instance {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<LightManager>();

                if (_instance  == null)
                {
                    GameObject go = new GameObject("Manager");
                    _instance = go.AddComponent<LightManager>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        //DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //light1.TurnOn();
            //light2.TurnOn();
            //light3.TurnOn();

            //? null-conditional operator (The Event will be invoked if it's not null)
            OnTurnOn?.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //light1.TurnOff();
            //light2.TurnOff();
            //light3.TurnOff();

            OnTurnOff?.Invoke();
        }
    }
}
