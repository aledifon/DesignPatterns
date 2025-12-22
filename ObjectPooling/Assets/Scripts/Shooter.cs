using UnityEngine;

public class Shooter : MonoBehaviour
{    
    [SerializeField] private float shootRate;
    [SerializeField] private float speed = 2.0f;

    [SerializeField] private ObjectPool projectilePool;

    private float lastShootTime;
     
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;   
        transform.Translate(moveInput * speed * Time.deltaTime);

        if (Input.GetMouseButton(0) && (Time.time - lastShootTime > shootRate))            
            Shoot();        
    }

    void Shoot()
    {
        // Get the current Time
        lastShootTime = Time.time;

        // Get a projectile from the pool and position it on the Shooter pos.
        GameObject projectileClone = projectilePool.GetObjects();
        projectileClone.transform.position = transform.position;

        // Finally initialize the projectile
        Vector3 shootDirection = new Vector3(Random.Range(-1,1), Random.Range(-1,1),0).normalized;
        projectileClone.GetComponent<Projectile>().Initialize(shootDirection);
    }
}
