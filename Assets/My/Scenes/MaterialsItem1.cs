using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsItem1 : MonoBehaviour, IInventoryItem
{

    public string Name
    {
        get
        {
            return "Sulfur";
        }
    }
    public Sprite _Image ;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickup()
    {
        // TODO: Add logic what happens when axe is picked up by player
        gameObject.SetActive(false);
    }
}

