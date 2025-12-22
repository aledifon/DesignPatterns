using UnityEngine;
using System;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;

    private Rigidbody rb;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();   
    }
    public void Initialize(Vector3 direction)
    {
        rb.linearVelocity = direction * speed;

        Invoke(nameof(Despawn), lifeTime);
    }
    public void Despawn()
    {
        gameObject.SetActive(false);
    }
}
