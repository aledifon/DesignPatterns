using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private int gold;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //button.onClick.AddListener(AddTenGold);        
        //button.onClick.AddListener(AddGold(5));
    }

    void AddGold(int amount)
    {
        gold += amount;
    }

    private void AddTenGold()
    {
        gold += 10;
    }
}
