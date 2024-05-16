namespace PzProjekt;

public class Actions
{
    public static void Fire(Fight fight)
    {
        fight.ActiveCharacter.Parameters.ActualHP -= 10;
    }
    
    public static void Heal(Fight fight)
    {
        fight.ActiveCharacter.Parameters.ActualHP += 10;
    }

    public static void AddStamina(Fight fight)
    {
        fight.ActiveCharacter.Parameters.ActualStamina += 10;
    }
    
    public static void BeginWeakness(Fight fight)
    {
        fight.InactiveCharacter.ActualStatistics.Agility -= 5;
        fight.InactiveCharacter.ActualStatistics.Defence -= 5;
    }
    
    public static void EndWeakness(Fight fight)
    {
        fight.ActiveCharacter.ActualStatistics.Agility = fight.ActiveCharacter.BaseStatistics.Agility;
        fight.ActiveCharacter.ActualStatistics.Defence = fight.ActiveCharacter.BaseStatistics.Defence;
    }
    
    public static void Freeze(Fight fight) { }
}