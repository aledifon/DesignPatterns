using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void Move(Vector3 movement)
    {
        transform.Translate(movement);
    }
}
