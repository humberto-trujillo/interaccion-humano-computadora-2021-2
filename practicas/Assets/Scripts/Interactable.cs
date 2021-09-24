using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool insideInteractionZone = false;
    public bool canBeSaved = true;
    public Item inventoryItem;
    public virtual void Interact()
    {
        Debug.Log("Interactuando");
    }

    void Update()
    {
        if (insideInteractionZone)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Interact();
            }
            else if (canBeSaved && Input.GetKeyDown(KeyCode.L))
            {
                if (inventoryItem != null)
                {
                    Inventory.Instance.Add(inventoryItem);
                    Destroy(gameObject);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entró a el area");
            insideInteractionZone = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Salió del area");
            insideInteractionZone = false;
        }
    }
}
