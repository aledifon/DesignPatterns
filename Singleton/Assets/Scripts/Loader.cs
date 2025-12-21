using UnityEngine;

public class Loader : MonoBehaviour
{
    private void Awake()
    {
        // Game Manager Loader Method
        // (In case no GameManager GO is on the Scene and the Loader Manage everything)
        if(!GameManager.Exist)
        {
            GameObject go = new GameObject("GameManager");
            go.AddComponent<GameManager>();
        }
    }
}
