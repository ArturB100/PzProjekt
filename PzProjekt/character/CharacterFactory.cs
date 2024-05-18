namespace PzProjekt;

public class CharacterFactory
{
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
    
    public static Character createRandomCharacterBasedOnLevel(int level, 
        List<Weapon> swords, 
        List<Weapon> axes, 
        List<Armour> helmets, 
        List<Armour> chestplates, 
        List<Armour> leggings, 
        List<Armour> boots,
        List<Spell> spells)
    {
        int points = 5 + level * 5;

        CharacterStatistics characterStatistics = new CharacterStatistics();
        
        Random random = new Random();
        
        while (points > 0)
        {
            int randomIndex = random.Next(0, characterStatistics.StatisticsDictionary.Count);
            characterStatistics.StatisticsDictionary[randomIndex]++;
            points--;
        }
        
        int randomNameIndex = random.Next(_characterNames.Count);
        string randomName = _characterNames[randomNameIndex];
        
        Weapon? weapon = null;
        
        if (characterStatistics.Agility > characterStatistics.Strength)
        {
            List<Weapon> matchingSwords = swords.Where(sword => sword.Statistics.Agility >= characterStatistics.Agility - 5 && sword.Statistics.Agility <= characterStatistics.Agility).ToList();
            weapon = GetRandomElement(matchingSwords);
        }
        else
        {
            List<Weapon> matchingAxes = axes.Where(axe => axe.Statistics.Strength >= characterStatistics.Strength - 5 && axe.Statistics.Strength <= characterStatistics.Strength).ToList();
            weapon = GetRandomElement(matchingAxes);
        }
        
        Armour? helmet = GetRandomElement(helmets.Where(helmet => helmet.MinLevel <= level).ToList());
        Armour? chestplate = GetRandomElement(chestplates.Where(chestplate => chestplate.MinLevel <= level).ToList());
        Armour? characterLeggings = GetRandomElement(leggings.Where(characterLeggings => characterLeggings.MinLevel <= level).ToList());
        Armour? characterBoots = GetRandomElement(boots.Where(characterBoots => characterBoots.MinLevel <= level).ToList());
        
        ArmourSet armourSet = new ArmourSet(helmet, chestplate, characterLeggings, characterBoots);

        Character character = new Character(randomName, characterStatistics, level, weapon, armourSet);
        
        int spellCount = random.Next(0, character.Parameters.MaxSpells + 1);
        List<Spell> availableSpells = spells.Where(spell => spell.Statistics.Magica <= characterStatistics.Magica).ToList();
        
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
    
    public static T GetRandomElement<T>(List<T> list)
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