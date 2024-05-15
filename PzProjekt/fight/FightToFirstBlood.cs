namespace PzProjekt;

public class FightToFirstBlood : Fight
{
    public FightToFirstBlood(Character player, Character enemy) : base(player, enemy) { }

    public override Result CheckFightResult()
    {
        if (!Player.HasArmor)
        {
            return Result.LOST;
        }
        
        if (!Enemy.HasArmor)
        {
            return Result.WON;
        }
        
        return Result.NONE;
    }

    public void EndFight(Result result)
    {
        if (result == Result.WON)
        {
            Player.CharacterMoney += MoneyToGet;
            Player.ExperiencePoints += ExperiencePointsToGet;
        }
        else if(result == Result.LOST)
        {
            Player.CharacterMoney -= MoneyToLose;
        }
    } 
}