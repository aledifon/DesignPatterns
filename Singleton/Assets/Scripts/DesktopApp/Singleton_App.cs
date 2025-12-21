using System;

// For C# Destkop Apps version (No-Game Dev)
// Used lazy initialization (', new()' on declaration
// and '??= new T()' on propety reading)
public class Singleton_App<T> where T : class, new()
{
    private static T _instance;
    public static T Instance => _instance ??= new T();

    protected Singleton_App()
    {        
        Init();
    }

    // Virtual method for initialisation
    protected virtual void Init()
    {
        // Here will go extra init code if needed        
    }

    //// In case of not using lazy initialization (User manages manually the class init)
    //public static void Initialize(T instance)
    //{
    //    if (_instance == null)
    //        _instance = instance;
    //    else
    //        throw new InvalidOperationException("Singleton not initialised");        
    //}
}
