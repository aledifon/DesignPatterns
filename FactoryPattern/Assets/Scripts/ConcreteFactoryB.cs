using UnityEngine;

public class ConcreteFactoryB : Factory
{
    [SerializeField] private ProductB productPrefab;
    public override IProduct Getproduct(Vector3 position)
    {
        // Create a prefab instance
        GameObject instance = Instantiate(productPrefab.gameObject,
                                        position, Quaternion.identity);
        ProductB newProduct = instance.GetComponent<ProductB>();

        newProduct.Initialize();

        return newProduct;
    }
}
