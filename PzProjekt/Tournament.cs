namespace PzProjekt;

public class Tournament
{
    public int MinimalLevel { get; set; }
    public int NumberOfEnemies { get; set; }
    public Character Boss { get; set; }
    
    private Queue<Character>? _enemies;

    public Tournament(int minimalLevel, int numberOfEnemies, Character boss)
    {
        MinimalLevel = minimalLevel;
        NumberOfEnemies = numberOfEnemies;
        Boss = boss;
    }

    public void InitializeEnemies(
        List<Weapon> swords, 
        List<Weapon> axes, 
        List<Armour> helmets, 
        List<Armour> chestplates, 
        List<Armour> leggings, 
        List<Armour> boots, 
        List<Spell> spells,
        List<Effect> effects)
    {
        _enemies = new Queue<Character>();
        
        for(int i = 0; i < NumberOfEnemies; i++)
        {
            _enemies.Enqueue(CharacterFactory.CreateRandomCharacterBasedOnLevel(MinimalLevel, swords, axes, helmets, chestplates, leggings, boots, spells, effects));
        }
        
        _enemies.Enqueue(Boss);
    }
    
    private Character NextEnemy
    {
        get => _enemies.Dequeue();
    }

    public Character ShowNextEnemy ()
    {
        return _enemies.Peek();
    }
    
    public FightToDeath CreateNextFightToDeath(Character player)
    {
        return new FightToDeath(player, NextEnemy, null);
    }

    public override string ToString()
    {
        return $"minimalny level: {MinimalLevel}, liczba walk: {NumberOfEnemies}, boss: {Boss.Name}";
    }
}