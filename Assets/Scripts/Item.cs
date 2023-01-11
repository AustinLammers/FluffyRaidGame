using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    
    public enum ItemType
    {
        gun,
        food,
        health,
    }

    public ItemType itemType;
    public int amount;
}
