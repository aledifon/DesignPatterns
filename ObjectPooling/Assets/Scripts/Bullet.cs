using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;

    private ObjectPool<GameObject> pool;
    private Rigidbody rb;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetPool(ObjectPool<GameObject> objectPool)
    {
        pool = objectPool;
    }
    public void Initialize(Vector3 direction)
    {
        rb.linearVelocity = direction * speed;

        Invoke(nameof(ReturnToPool), lifeTime);
    }
    private void ReturnToPool()
    {
        pool.Release(gameObject);
    }
}
