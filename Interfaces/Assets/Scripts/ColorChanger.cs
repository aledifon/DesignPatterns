using UnityEngine;

public class ColorChanger : MonoBehaviour, IInteractable
{
    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    public void Interact()
    {        
        rend.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
