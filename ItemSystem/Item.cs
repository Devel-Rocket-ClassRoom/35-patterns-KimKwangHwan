using System;
using System.Collections.Generic;
using System.Text;

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

public class Item
{
    public Item(string name, Rarity itemRarity)
    {
        Name = name;
        ItemRarity = itemRarity;
    }
    public string Name { get; set; }
    
    public Rarity ItemRarity { get; set; }

    public virtual int GetItemValue() => ItemRarity switch
    {
        Rarity.Common => 10,
        Rarity.Uncommon => 50,
        Rarity.Rare => 200,
        Rarity.Epic => 1000,
        Rarity.Legendary => 5000,
        _ => 0
    };
}