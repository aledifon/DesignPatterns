using System;

public class TestScript_App
{    
    private static void Main(string[] args)
    {
        // Force Singleton initialization        
        Loader_App.InitializeAll();    

        GameManager_App.Instance.AddScore(5);
        Console.WriteLine(GameManager_App.Instance.Score);
    }
}
