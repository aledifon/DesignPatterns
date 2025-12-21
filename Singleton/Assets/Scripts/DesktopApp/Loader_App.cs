using System;
using UnityEngine;

public class Loader_App : MonoBehaviour
{
    public static void InitializeAll()
    {
        // Forzar creación de los Singletons
        var gm = GameManager_App.Instance; // Lazy initialization crea automáticamente
        //var am = AudioManager.Instance;    // Otro singleton
        //var lm = LevelManager.Instance;    // Otro singleton

        Console.WriteLine("Todos los Singletons inicializados");
    }
}
