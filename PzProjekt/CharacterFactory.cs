namespace PzProjekt;

public class CharacterFactory
{
    static List<string> characterNames = new List<string>
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

        Statistics statistics = new Statistics();
        
        Random random = new Random();
        
        while (points > 0)
        {
            int randomIndex = random.Next(0, statistics.statisticsDictionary.Count);
            statistics.statisticsDictionary[randomIndex]++;
            points--;
        }
        
        int randomNameIndex = random.Next(characterNames.Count);
        string randomName = characterNames[randomNameIndex];

        return new Character(randomName, statistics, level, new Sword(0, 10, EffectType.NONE));    
    }
}