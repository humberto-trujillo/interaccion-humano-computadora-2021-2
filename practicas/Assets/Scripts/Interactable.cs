using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool insideInteractionZone = false;

    public void Interact()
    {
        if (insideInteractionZone)
        {
            Debug.Log("Interactuando");
        }
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            insideInteractionZone = true;
            Debug.Log("Entró a el area");
        }
    }

    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            insideInteractionZone = false;
            Debug.Log("Salió del area");
        }
    }
}
