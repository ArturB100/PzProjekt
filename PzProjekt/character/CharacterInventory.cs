using System.Text;
using PzProjekt.exceptions;

namespace PzProjekt;

public class CharacterInventory
{
    private Character _character;
    
    public CharacterInventory(Character character)
    {
        CharacterSpells = new List<Spell>();
        AvailableSpells = new List<Spell>();
        ArmourSet = new ArmourSet();
        _character = character;
    }
    
    public CharacterInventory(Character character, Weapon weapon, ArmourSet armourSet)
    {
        CharacterSpells = new List<Spell>();
        AvailableSpells = new List<Spell>();
        ArmourSet = new ArmourSet();
        
        Weapon = weapon;
        ArmourSet = armourSet;
        _character = character;
    }
    
    public Weapon? Weapon { get; set; }
    public ArmourSet ArmourSet { get; set; }
    public List<Spell> CharacterSpells { get; set; }
    public List<Spell> AvailableSpells { get; set; }

    public void ChangeSpell(int index, Spell spell)
    {
        CharacterSpells[index] = spell;
        AvailableSpells[index] = spell;
    }
    
    public void AddSpell(Spell spell)
    {
        if(_character.Parameters.MaxSpells <= CharacterSpells.Count)
        {
            throw new TooManySpellsException();
        }
        
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

    public void EquipSpell (Spell spell)
    {
        CharacterSpells.Add(spell);
    }

    public void EquipEffect ( Effect effect) 
    {

        if (Weapon == null)
        {
            throw new NoWeaponInInventoryException();
        }

        Weapon.Effect = effect;
    }
    
    public String SpellsToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var spell in CharacterSpells)
        {
            sb.Append(spell.Name);
            sb.Append("\n");
        }

        return sb.ToString();
    }
}