using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Pool;

public class PoolExample : MonoBehaviour
{
    [SerializeField] private int defaultCapacity = 5;
    [SerializeField] private int maxPoolSize = 6;
    [SerializeField] private GameObject prefab;
 
    private ObjectPool<GameObject> pool;

    void Awake()
    {
        // constructor
        pool = new ObjectPool<GameObject>(CreatePoolItem, OnTakeFromPool, OnReturnedToPool,
                            OnDestroyPoolObject, false, defaultCapacity, maxPoolSize);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) Shoot();
    }

    GameObject GetBullet()
    {
        GameObject bullet = pool.Get();
        // Assign the pool in order to the bullet know how to come back
        bullet.GetComponent<Bullet>().SetPool(pool);

        return bullet;
    }   
    void Shoot()
    {
        GameObject _bullet = GetBullet();

        _bullet.transform.position = transform.position;

        // Finally initialize the projectile
        Vector3 shootDirection = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0).normalized;
        _bullet.GetComponent<Bullet>().Initialize(shootDirection);
    }
    GameObject CreatePoolItem()
    {
        GameObject obj = Instantiate(prefab);
        obj.SetActive(false);

        return obj;
    }
    void OnTakeFromPool(GameObject _object)
    {
        _object.SetActive(true);
    }
    void OnReturnedToPool(GameObject _object)
    {
        _object.SetActive(false);
    }
    void OnDestroyPoolObject(GameObject _object)
    {
        Destroy(_object);
    }
}
