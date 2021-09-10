using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool insideInteractionZone = false;
    public virtual void Interact()
    {
        Debug.Log("Interactuando");
    }

    void Update()
    {
        if (insideInteractionZone && Input.GetKeyDown(KeyCode.I))
        {
            Interact();
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
