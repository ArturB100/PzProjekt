namespace PzProjekt;

public class ArmourShop
{
    private List<Armour> helmets = new List<Armour>
    {
        new Armour(1, "Leather Helmet", 10, ArmourType.Helmet, 1),
        new Armour(3, "Iron Helmet", 20, ArmourType.Helmet, 3),
        new Armour(5, "Dragon Helmet", 50, ArmourType.Helmet, 5)
    };
    
    private List<Armour> chestplates = new List<Armour>
    {
        new Armour(1, "Leather Chestplate", 10, ArmourType.Chestplate, 1),
        new Armour(3, "Iron Chestplate", 20, ArmourType.Chestplate, 3),
        new Armour(5, "Dragon Chestplate", 50, ArmourType.Chestplate, 5)
    };
    
    private List<Armour> leggings = new List<Armour>
    {
        new Armour(1, "Leather Leggings", 10, ArmourType.Leggings, 1),
        new Armour(3, "Iron Leggings", 20, ArmourType.Leggings, 3),
        new Armour(5, "Dragon Leggings", 50, ArmourType.Leggings, 5)
    };
    
    private List<Armour> boots = new List<Armour> 
    {
        new Armour(1, "Leather Boots", 10, ArmourType.Boots, 1),
        new Armour(3, "Iron Boots", 20, ArmourType.Boots, 3),
        new Armour(5, "Dragon Boots", 50, ArmourType.Boots, 5)
    };
    
    public void buyArmour(Character character, Armour armour)
    {   
        
        character.Parameters.Money -= armour.ValueInGold;
        
        switch (armour.ArmourType)
        {
            case ArmourType.Helmet:
                character.Inventory.ArmourSet.Helmet = armour;
                break;
            case ArmourType.Chestplate:
                character.Inventory.ArmourSet.Chestplate = armour;
                break;
            case ArmourType.Leggings:
                character.Inventory.ArmourSet.Leggings = armour;
                break;
            case ArmourType.Boots:
                character.Inventory.ArmourSet.Boots = armour;
                break;
        }
    }
}