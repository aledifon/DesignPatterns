using UnityEngine;

public class ProductA : MonoBehaviour, IProduct
{
    [SerializeField] private float power;
    [SerializeField] private string productName = "ProductA";

    public string ProductName { get => productName; set => productName = value; }

    private Rigidbody rb;

    public void Initialize()
    {
        // Specific logic of this object
        gameObject.name = productName;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * power);
    }
}
