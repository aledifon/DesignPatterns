using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Without Singleton pattern
    //[SerializeField] GameManager gameManager;

    void Start()
    {
        // Without singleton pattern
        //gameManager.AddScore(5);   

        GameManager.Instance.AddScore(5);
    }
}
