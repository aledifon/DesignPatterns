using UnityEngine;

public class Ball : MonoBehaviour, IInteractable
{
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Interact()
    {
        rb.AddForce(Vector3.up * 8, ForceMode.Impulse);
    }
}
