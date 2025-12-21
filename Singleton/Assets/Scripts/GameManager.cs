using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static bool Exist => (Instance != null);
    public int Score {  get; private set; }    

    // Single Pattern implemented on Singleton.cs
    // (Also compatible with Loader.cs implementation)            

    // Just in case we need to extend the Awake class
    //protected override void Awake()
    //{
    //    // Awake implemented on parent class Singleton
    //    base.Awake();

    //    // Rest of code
    //}

    public void AddScore(int amount) => Score += amount;    
}
