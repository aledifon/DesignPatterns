using System.Collections.Generic;
using UnityEngine;

public class ClickToCreate : MonoBehaviour
{
    [SerializeField] private LayerMask layerToClick;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Factory[] factories;

    private List<GameObject> createdProducts = new List<GameObject>();

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            GetProductAtClick();
    }
    private void GetProductAtClick()
    {
        // Get a random factory
        Factory selectedFactory = factories[Random.Range(0, factories.Length)];

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerToClick) 
            && selectedFactory != null)
        {
            IProduct product = selectedFactory.Getproduct(hit.point + offset);

            // Check if product is Component type or inherits from Component type
            // As ProductA and ProductB inherit from Monobehaviour are Component Types
            if(product is Component component)
            {
                createdProducts.Add(component.gameObject);
            }
        }

    }
}
