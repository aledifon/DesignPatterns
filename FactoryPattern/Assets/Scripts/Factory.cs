using UnityEngine;

// The common template for all the factories
public abstract class Factory : MonoBehaviour
{
    public abstract IProduct Getproduct(Vector3 position);

    //common methods to every type of factory
}
