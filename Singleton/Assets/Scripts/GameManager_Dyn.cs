using UnityEngine;

public class GameManager_Dyn : MonoBehaviour
{
    public int Score {  get; private set; }

    //Dynamic Creation of GameManager Instance
    //(No GameManager GO needs to exist on the Scene)
    private static GameManager_Dyn _instance;
    public static GameManager_Dyn instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<GameManager_Dyn>();

                if (_instance == null)
                {
                    GameObject go = new GameObject("GameManager");
                    _instance = go.AddComponent<GameManager_Dyn>();
                }
            }
            return _instance;
        }
    }

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
