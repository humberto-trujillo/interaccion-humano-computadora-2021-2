using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Generic")]
public class Item : ScriptableObject
{
    public Sprite inventoryIconSprite = null;

    public virtual void Use()
    {
        Debug.Log($"Usando item {name}");
    }
    
}
