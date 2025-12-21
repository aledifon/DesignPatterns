
// For C# Destkop Apps version (No-Game Dev)
public class GameManager_App : Singleton_App<GameManager>
{
    public static bool Exist => (Instance != null);
    public int Score {  get; private set; }

    // Single Pattern implemented on Singleton_App.cs
    // (Also compatible with Loader.cs implementation)            

    // Just in case we need to extend the Init Method (equivalent to exte the Awake method)
    protected override void Init()
    {
        // Awake implemented on parent class Singleton
        base.Init();

        // Rest of code
    }

    public void AddScore(int amount) => Score += amount;    
}
