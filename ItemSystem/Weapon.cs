using System;
using System.Collections.Generic;
using System.Text;

public enum WeaponType
{
    Sword,
    Bow,
    Staff
}
public class Weapon : Item
{
    public Weapon(string name, int damage, Rarity itemRarity, WeaponType weaponType) : base(name, itemRarity)
    {
        Damage = damage;
        type = weaponType;
    }

    public int Damage { get; set; }
    public WeaponType type { get; set; }

    public override int GetItemValue()
    {
        return base.GetItemValue() + (Damage * 10);
    }
}