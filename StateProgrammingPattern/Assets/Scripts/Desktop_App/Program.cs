using System.Threading;

public class Program 
{
    static void Main(string[] args)
    {
        //PlayerControllerS_App playerController = new PlayerControllerS_App();
        var playerController = new PlayerControllerS_App();
        playerController.Start();

        while (true)
        {
            playerController.Update();
            Thread.Sleep(16);               //~60 FPS
        }            
    }
}
