namespace PzProjekt;

public class Effects
{
    public static void Poison(Fight fight)
    {
        fight.ActiveCharacter.Parameters.ActualHP -= 10;
    }
    
    public static void Weakness(Fight fight)
    {
        fight.ActiveCharacter.Parameters.ActualStamina -= 10;
    }
    
    public static void Freeze(Fight fight) { }
}