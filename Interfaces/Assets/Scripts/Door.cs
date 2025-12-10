using Unity.Mathematics;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    private bool isOpen;

    public void Interact()
    {
        if (isOpen)
            transform.eulerAngles += Vector3.up * 90;
        else
            transform.eulerAngles -= Vector3.up * 90;

        isOpen = !isOpen;
    }
}
