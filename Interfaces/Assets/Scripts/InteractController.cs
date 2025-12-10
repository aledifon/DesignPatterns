using UnityEngine;

public class InteractController : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) TryInteract();   
    }

    void TryInteract()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            // Verify the object the raycast is hitting
            //if (hit.collider.GetComponent<Ball>())
            //    hit.collider.GetComponent<Ball>().Interact();
            //else if (hit.collider.GetComponent<ColorChanger>())
            //    hit.collider.GetComponent<ColorChanger>().Interact();
            //else if (hit.collider.GetComponent<Door>())
            //    hit.collider.GetComponent<Door>().Interact();

            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)            
                interactable.Interact();                     
        }
    }
}
