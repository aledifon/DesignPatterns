using UnityEngine;
using System;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float minimumAmount;

    private List<GameObject> pool = new List<GameObject>();

    private void Start()
    {
        //Create the pool objects
        for (int i = 0; i < minimumAmount ; i++)        
            CreateNewObject();        
    }
    GameObject CreateNewObject()
    {
        GameObject obj = Instantiate(prefab);
        pool.Add(obj);
        obj.SetActive(false);

        return obj;
    }

    // Pull object from the pool
    public GameObject GetObjects()
    {
        // Get the 1st Object from the pool that is not active (through lambda expression)
        GameObject obj = pool.Find(p => p.activeSelf == false);

        // In case there is no any deactivated object remaining on the pool
        // then we'll create a new one
        if (obj == null)
            obj = CreateNewObject();
        
        // Enable the pulled object and return it.
        obj.SetActive(true);
        return obj;
    }
}
