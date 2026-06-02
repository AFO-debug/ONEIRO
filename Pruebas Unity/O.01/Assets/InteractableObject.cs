using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
  //The base class for interactable objects (Items, Doors, Levers, Etc)

protected PlayerMovement player; //The player interacting with the object
protected Collider interactableCollider; //The collider enabling interaction when the player is close enough for interaction
[SerializeField] protected GameObject interactableImage; //The image indicating a player can interact with this object
protected virtual void OnTriggerEnter(Collider other)
{
    // OPTIONAL: Check for specific layer of collider

    if (player == null)
    {
        player = other.GetComponent<PlayerMovement>();
    }

    if (player != null)
    {
        interactableImage.SetActive(true);
    }
}

protected virtual void OnTriggerExit(Collider other)
{
    // OPTIONAL: Check for specific layer of collider

    if (player == null)
    {
        player = other.GetComponent<PlayerMovement>();
    }

    if (player != null)
    {
        interactableImage.SetActive(false);
    }
}
protected virtual void OnTriggerStay(Collider other)
{
    if (Input.GetButtonDown("Interact"))
{
    Interact();
}
}
protected virtual void Interact()
{
    Debug.Log("Ya interactuaste papi");
}

}
