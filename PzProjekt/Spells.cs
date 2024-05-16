namespace PzProjekt;

public class Spells
{
    public static void Teleport(Fight fight)
    {
        Random random = new Random();
        
        Console.WriteLine("Character position before teleportation: " + fight.ActiveCharacter.Parameters.Position);
        
        fight.ActiveCharacter.Parameters.Position = random.Next(0, 1000);
        
        Console.WriteLine("Character position after teleportation: " + fight.ActiveCharacter.Parameters.Position);
    }
    
    public static void Fireball(Fight fight)
    {
        fight.CharacterFightActions.TakeDamage(100);
    }
}