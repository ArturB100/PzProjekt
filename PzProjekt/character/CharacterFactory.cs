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
    
    public static Character createRandomCharacterBasedOnLevel(int level)
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

        return new Character(randomName, characterStatistics, level, new Weapon(1, "Fist", 0, WeaponType.Sword, 1, 1));    
    }
}