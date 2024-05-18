using PzProjekt.exceptions;

namespace PzProjekt;

public  class Shop <T>  where T : InventoryItem
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

    public List<T> GetItems () { return items; }

    public List<string> GetItemsAsString ()
    {
        List<string> result = new List<string>();
        foreach (T item in items)
        {
            result.Add(item.ToStringWithProperties());
        }
        return result;
    }
    
    public bool CanBeBoughtByPlayer ( Character character, T item)
    {
        bool success =
        (
            character.Parameters.Money >= item.ValueInGold &&
            character.Parameters.Level >= item.MinLevel &&
            character.BaseStatistics.IsGreater(item.Statistics)
        );
        if (success) { return true; }

        if (!(character.Parameters.Money >= item.ValueInGold))
        {
            throw new NoEnoughMoneyException();
        }

        if (!(character.Parameters.Level >= item.MinLevel))
        {
            throw new TooWeakLevelException();
        }

        if (!(character.BaseStatistics.IsGreater(item.Statistics)))
        {
            throw new TooWeakStatisticsException();
        }
        return false;
        

        
    }

    public virtual void BuyItem(Character character, T inventoryItem)
    {
        if (!CanBeBoughtByPlayer(character, inventoryItem))
        {
            throw new ItemImpossibleToBuy();
        }

        EquipItem?.Invoke(character, inventoryItem);
        character.Parameters.Money -= Convert.ToInt32(inventoryItem.ValueInGold * (1 - character.BaseStatistics.Charisma * 0.01));
     
       
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
        character.Inventory.EquipArmour(inventoryItem);
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
        character.Inventory.EquipWeapon(inventoryItem);
    }
}



public class SpellShop : Shop<Spell>
{
    public SpellShop() : base()
    {
        EquipItem += ArmourShop_EquipItem;
    }
    private void ArmourShop_EquipItem(Character character, Spell inventoryItem)
    {
        character.Inventory.EquipSpell(inventoryItem);
    }
}



public class EffectShop : Shop<Effect>
{
    public EffectShop() : base()
    {
        EquipItem += ArmourShop_EquipItem;
    }
    private void ArmourShop_EquipItem(Character character, Effect effect)
    {
        character.Inventory.EquipEffect(effect);
    }
}