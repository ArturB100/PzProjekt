namespace PzProjekt;

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
        character.CharacterMoney -= Convert.ToInt32(inventoryItem.ValueInGold * (1 - character.CharacterStatistics.Charisma * 0.01));

        EquipItem?.Invoke(character, inventoryItem);
    }
}