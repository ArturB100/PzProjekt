namespace PzProjekt;

public class CharacterInventory
{
    public CharacterInventory()
    {
        CharacterSpells = new List<Spell>();
        AvailableSpells = new List<Spell>();
        ArmourSet = new ArmourSet();
    }

    public Weapon Weapon { get; set; }
    public ArmourSet ArmourSet { get; set; }
    public List<Spell> CharacterSpells { get; set; }
    public List<Spell> AvailableSpells { get; set; }

    public void AddSpell(Spell spell)
    {
        CharacterSpells.Add(spell);
        AvailableSpells.Add(spell);
    }
    
    public void Refill()
    {
        ArmourSet.ActualArmorPoints = ArmourSet.MaxArmorPoints;
        AvailableSpells = new List<Spell>(CharacterSpells);
    }
    
    public bool HasArmor
    {
        get => ArmourSet.ActualArmorPoints > 0;
    }

    public void EquipArmour(Armour armour)
    {
        if (ArmourSet == null)
        {
            ArmourSet = new ArmourSet();
        }


        switch (armour.ArmourType)
        {
            case ArmourType.Helmet:
                ArmourSet.Helmet = armour;
                break;
            case ArmourType.Chestplate:
                ArmourSet.Chestplate = armour;
                break;
            case ArmourType.Leggings:
                ArmourSet.Leggings = armour;
                break;
            case ArmourType.Boots:
                ArmourSet.Boots = armour;
                break;
        }
    }

    public void EquipWeapon (Weapon weapon)
    {
        Weapon =  weapon;
    }

}