using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class Inventory : MonoBehaviour
{
    [SerializeField] private TMP_Text m_Text;

    private Dictionary<string, int> items = new Dictionary<string, int>();

    public void AddItem(string itemName)
    {
        if (items.ContainsKey(itemName))
            items[itemName]++;
        else
            items.Add(itemName, 1);

        UpdateInventoryText();
    }
    public void RemoveItem(string itemName)
    {
        if (items.ContainsKey(itemName))
        {            
            items[itemName]--;

            if (items[itemName] == 0)
                items.Remove(itemName);
        }

        UpdateInventoryText();
    }

    // The dictionaries are not serializables
    void UpdateInventoryText()
    {
        m_Text.text = string.Empty;

        foreach(KeyValuePair<string, int> item in items)
        {
            m_Text.text += string.Format("{0} x{1}\n", item.Key, item.Value);
        }
    }
}
