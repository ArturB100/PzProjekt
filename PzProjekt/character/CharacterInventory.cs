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
}