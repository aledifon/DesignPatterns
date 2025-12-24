using UnityEngine;

public class ConcreteFactoryA : Factory
{
    [SerializeField] private ProductA productPrefab;
    public override IProduct Getproduct(Vector3 position)
    {
        // Create a prefab instance
        GameObject instance = Instantiate(productPrefab.gameObject,
                                        position, Quaternion.identity);
        ProductA newProduct = instance.GetComponent<ProductA>();

        newProduct.Initialize();

        return newProduct;
    }
}
