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

    public static void Gale(Fight fight)
    {
        if(fight.InactiveCharacter.Parameters.Position < fight.ActiveCharacter.Parameters.Position)
        {
            fight.InactiveCharacter.Parameters.Position = 0;
        }
        else
        {
            fight.InactiveCharacter.Parameters.Position = 1000;
        }    
    }

    public static void Adulation(Fight fight)
    {
        fight.CrowdSatisfaction += 20;
    }

    public static void Command(Fight fight)
    {
        fight.InactiveCharacter.Parameters.Position = fight.ActiveCharacter.Parameters.Position;
    }
    
    public static void Fireball(Fight fight)
    {
        fight.CharacterFightActions.TakeDamage(100);
    }
    
    public static void Heal(Fight fight)
    {
        fight.ActiveCharacter.Parameters.ActualHP += 100;
    }
    
    public static void AddStamina(Fight fight)
    {
        fight.ActiveCharacter.Parameters.ActualStamina += 100;
    }
    
    public static void GhostStrike(Fight fight)
    {
        fight.CharacterFightActions.Attack(AttackType.STRONG);
    }
    
    public static void WeakenArmor(Fight fight)
    {
        fight.InactiveCharacter.Inventory.ArmourSet.ActualArmorPoints /= 2;
    }
    
    public static void Rejuvinate(Fight fight)
    {
        fight.ActiveCharacter.Parameters.Refill();
        fight.ActiveCharacter.Inventory.ArmourSet.ActualArmorPoints = fight.ActiveCharacter.Inventory.ArmourSet.MaxArmorPoints;
    }
}