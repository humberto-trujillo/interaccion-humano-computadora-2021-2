using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Interactable
{
    // Start is called before the first frame update
    public Vector3 rotationAxis;
    public override void Interact()
    {
        base.Interact();
        transform.Rotate(rotationAxis, 45f);
    }
}
