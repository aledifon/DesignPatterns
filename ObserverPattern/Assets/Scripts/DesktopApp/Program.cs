using System;

public class Program
{
    static void Main(string[] args)
    {                
        var controller = new LightController_App();

        try
        {
            while (true)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.A)
                    LightManager_App.Instance.TurnOnAll();
                else if (key == ConsoleKey.D)
                    LightManager_App.Instance.TurnOffAll();
            }
        }
        finally
        {
            // Al salir del loop, liberamos recursos
            controller.Dispose();
        }
    }
}
