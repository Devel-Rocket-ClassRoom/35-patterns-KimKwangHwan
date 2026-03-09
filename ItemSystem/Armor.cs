using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public enum ArmorType
{
    Helmet,
    Chest,
    Boots
}

public class Armor : Item
{
    public Armor(string name, int defense, Rarity itemRarity, ArmorType armorType) : base(name, itemRarity)
    {
        Defense = defense;
        type = armorType;
    }
    public int Defense { get; set; }
    public ArmorType type { get; set; }

    public override int GetItemValue()
    {
        return base.GetItemValue() + (Defense * 15);
    }
}