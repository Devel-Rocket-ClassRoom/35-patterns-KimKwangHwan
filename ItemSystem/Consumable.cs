using System;
using System.Collections.Generic;
using System.Text;

public class Consumable : Item
{
    public Consumable(string name, string effect, int duration, Rarity itemRarity) : base(name, itemRarity)
    {
        Effect = effect;
        Duration = duration;
    }
    public string Effect { get; set; }
    public int Duration { get; set; }
    public override int GetItemValue()
    {
        return base.GetItemValue() + (Duration * 5);
    }

}