﻿namespace PzProjekt;

public abstract class Shop <T>  where T : InventoryItem
{
    private List<T> items = new List<T>();
    public delegate void EquipItemDelegate(Character character, T inventoryItem);
    public event EquipItemDelegate EquipItem;
    
    public void AddItem(T item)
    {
        items.Add(item);
    }
    
    public void AddItems(List<T> items)
    {
        this.items.AddRange(items);
    }
    
    public virtual void BuyItem(Character character, T inventoryItem)
    {
        character.Parameters.Money -= Convert.ToInt32(inventoryItem.ValueInGold * (1 - character.BaseStatistics.Charisma * 0.01));

        EquipItem?.Invoke(character, inventoryItem);
    }



   
}

public class ArmourShop : Shop<Armour>
{
    public ArmourShop() : base()
    {
        EquipItem += ArmourShop_EquipItem;
    }
    private void ArmourShop_EquipItem(Character character, Armour inventoryItem)
    {
        character.EquipArmour(inventoryItem);
    }
}


public class WeaponShop : Shop<Weapon>
{
    public WeaponShop() : base()
    {
        EquipItem += ArmourShop_EquipItem;
    }
    private void ArmourShop_EquipItem(Character character, Weapon inventoryItem)
    {
        character.EquipWeapon(inventoryItem);
    }
}