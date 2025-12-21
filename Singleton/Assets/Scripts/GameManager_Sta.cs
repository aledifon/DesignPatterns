using UnityEngine;

public class GameManager_Sta : MonoBehaviour
{
    public int Score {  get; private set; }  

    // Single Creation of GameManager Instance
    // (A single GameManager GO needs with GameManager comp. attached to exist on the Initial Scene)
    // (Also compatible with Loader.cs implementation)
    private static GameManager_Sta _instance;
    public static GameManager_Sta Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("GameManager no inicializado. ¿Está en la escena inicial?");
            }
            return _instance;
        }
    }
    public static bool Exist => (_instance != null);

    private void Awake()
    {        
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);        

        // Rest of code
    }

    public void AddScore(int amount) => Score += amount;    
}
