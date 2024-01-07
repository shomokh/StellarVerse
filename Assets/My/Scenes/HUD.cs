using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Inventory Inventory;

    // Use this for initialization
    
    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
    }

    private void InventoryScript_ItemAdded (object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach (Transform Slot in inventoryPanel)
        { 
            // Border ... Image
            Image image = Slot.GetChild(0).GetChild(0).GetComponent<Image>();

            // We found the empty slot
            if (!image.enabled )
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                // TODO: Store a reference to the item

                break;
            }
        }
    }
}
