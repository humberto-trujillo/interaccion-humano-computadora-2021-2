using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item item;
    public Image image;
    public void TestSlot()
    {
        Debug.Log("Click a "+ gameObject.name);
    }

    public void Set(Item item)
    {
        this.item = item;
        image.sprite = item.inventoryIconSprite;
    }

    public void Clear()
    {
        this.item = null;
        image.sprite = null;
    }
}
