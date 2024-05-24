namespace PzProjekt;

public class CharacterFactory
{
    private const double ChanceToGetEffect = 0.5;
    private const int BasePoints = 5;
    private const int PointsLevelMultiplier = 5;
    private const int WeaponStatisticsDifference = 5;
    private const int ArmorLevelDifference = 11;
    
    private static List<string> _characterNames = new List<string>
    {
        "Maximus",
        "Aurelius",
        "Decimus",
        "Valerius",
        "Cassius",
        "Spartacus",
        "Gaius",
        "Titus",
        "Octavius",
        "Lucius",
        "Quintus",
        "Marcellus",
        "Flavius",
        "Felix",
        "Antonius",
        "Tiberius"
    };
    
    public static Character CreateRandomCharacterBasedOnLevel(int level, 
        List<Weapon> swords, 
        List<Weapon> axes, 
        List<Armour> helmets, 
        List<Armour> chestplates, 
        List<Armour> leggings, 
        List<Armour> boots,
        List<Spell> spells,
        List<Effect> effects)
    {
        int pointsToInvest = BasePoints + level * PointsLevelMultiplier;

        CharacterStatistics characterStatistics = new CharacterStatistics();
        
        Random random = new Random();
        
        while (pointsToInvest > 0)
        {
            int randomIndex = random.Next(0, characterStatistics.StatisticsDictionary.Count);
            characterStatistics.StatisticsDictionary[randomIndex]++;
            pointsToInvest--;
        }
        
        int randomNameIndex = random.Next(_characterNames.Count);
        string randomName = _characterNames[randomNameIndex];
        
        Weapon? weapon;
        
        if (characterStatistics.Agility > characterStatistics.Strength)
        {
            List<Weapon> matchingSwords = swords.Where(sword => sword.MinimalStatistics.Agility >= characterStatistics.Agility - WeaponStatisticsDifference && sword.MinimalStatistics.Agility <= characterStatistics.Agility).ToList();
            weapon = GetRandomElement(matchingSwords).Clone() as Weapon;
        }
        else
        {
            List<Weapon> matchingAxes = axes.Where(axe => axe.MinimalStatistics.Strength >= characterStatistics.Strength - WeaponStatisticsDifference && axe.MinimalStatistics.Strength <= characterStatistics.Strength).ToList();
            weapon = GetRandomElement(matchingAxes).Clone() as Weapon;
        }
        
        if (weapon != null)
        {
            if (random.NextDouble() <= ChanceToGetEffect)
            {
                Effect randomEffect = GetRandomElement(effects);
                weapon.Effect = randomEffect;
            }
        }
        
        Armour? helmet = GetRandomElement(getArmorsBasedOnLevel(level, helmets));
        Armour? chestplate = GetRandomElement(getArmorsBasedOnLevel(level, chestplates));
        Armour? characterLeggings = GetRandomElement(getArmorsBasedOnLevel(level, leggings));
        Armour? characterBoots = GetRandomElement(getArmorsBasedOnLevel(level, boots));
        
        ArmourSet armourSet = new ArmourSet(helmet, chestplate, characterLeggings, characterBoots);

        Character character = new Character(randomName, characterStatistics, level, weapon, armourSet);
        
        int spellCount = random.Next(0, character.Parameters.MaxSpells);
        List<Spell> availableSpells = spells.Where(spell => spell.MinimalStatistics.Magica <= characterStatistics.Magica).ToList();
        
        if(availableSpells.Count < spellCount)
        {
            spellCount = availableSpells.Count;
        }
        
        for(int i = 0; i < spellCount; i++)
        {
            Spell randomSpell = GetRandomElement(availableSpells);
            character.Inventory.AddSpell(randomSpell);
        }
        
        return character;    
    }
    
    private static List<Armour> getArmorsBasedOnLevel(int level, List<Armour> armours)
    {
        return armours.Where(armour => armour.MinLevel <= level && armour.MinLevel >= level - ArmorLevelDifference).ToList();
    }
    
    private static T GetRandomElement<T>(List<T> list)
    {
        if (list == null || !list.Any())
        {
            return default;
        }

        Random random = new Random();
        int randomIndex = random.Next(list.Count);
        return list[randomIndex];
    }
}