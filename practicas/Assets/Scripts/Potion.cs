using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Potion", menuName = "Inventory/Potion")]
public class Potion : Item
{
    public float lifeGain;
    public float magicGain;

    public override void Use()
    {
        base.Use();
        // subir vida al personaje...
        // respawn del objeto...
    }
}
