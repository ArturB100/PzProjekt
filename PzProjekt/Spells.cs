namespace PzProjekt;

public class Spells
{
    public static void Teleport(Fight fight)
    {
        Random random = new Random();
        
        Console.WriteLine("Character position before teleportation: " + fight.ActiveCharacter.Position);
        
        fight.ActiveCharacter.Position = random.Next(0, 1000);
        
        Console.WriteLine("Character position after teleportation: " + fight.ActiveCharacter.Position);
    }
    
    public static void Fireball(Fight fight)
    {
        fight.InactiveCharacter.takeDamage(100);
    }
}