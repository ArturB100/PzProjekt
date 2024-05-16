namespace PzProjekt;

public class FightToFirstBlood : Fight
{
    public FightToFirstBlood(Character player, Character enemy) : base(player, enemy) { }

    public override Result CheckFightResult()
    {
        if (!Player.Inventory.HasArmor)
        {
            return Result.LOST;
        }
        
        if (!Enemy.Inventory.HasArmor)
        {
            return Result.WON;
        }
        
        return Result.NONE;
    }

    public void EndFight(Result result)
    {
        if (result == Result.WON)
        {
            Player.Parameters.Money += MoneyToGet;
            Player.Parameters.ExperiencePoints += ExperiencePointsToGet;
        }
        else if(result == Result.LOST)
        {
            Player.Parameters.Money -= MoneyToLose;
        }
    } 
}