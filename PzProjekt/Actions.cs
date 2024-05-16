namespace PzProjekt;

public class Actions
{
    public static void Poison(Fight fight)
    {
        fight.ActiveCharacter.Parameters.ActualHP -= 10;
    }
    
    public static void BeginWeakness(Fight fight)
    {
        fight.InactiveCharacter.ActualStatistics.Agility -= 5;
        fight.InactiveCharacter.ActualStatistics.Defence -= 5;
        fight.InactiveCharacter.ActualStatistics.Attack -= 5;
        fight.InactiveCharacter.ActualStatistics.Stamina -= 5;
        fight.InactiveCharacter.ActualStatistics.Strength -= 5;
    }
    
    public static void EndWeakness(Fight fight)
    {
        fight.ActiveCharacter.ActualStatistics.Agility = fight.ActiveCharacter.BaseStatistics.Agility;
        fight.ActiveCharacter.ActualStatistics.Defence = fight.ActiveCharacter.BaseStatistics.Defence;
        fight.InactiveCharacter.ActualStatistics.Attack = fight.ActiveCharacter.BaseStatistics.Attack;
        fight.InactiveCharacter.ActualStatistics.Stamina = fight.ActiveCharacter.BaseStatistics.Stamina;
        fight.InactiveCharacter.ActualStatistics.Strength = fight.ActiveCharacter.BaseStatistics.Strength;
    }
    
    public static void Freeze(Fight fight) { }
}