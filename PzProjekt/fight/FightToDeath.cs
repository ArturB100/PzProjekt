namespace PzProjekt;

public class FightToDeath : Fight
{
    public FightToDeath(Character player, Character enemy) : base(player, enemy) { }
    
    public override Result CheckFightResult()
    {
        if (!Player.Parameters.IsAlive)
        {
            return Result.LOST;
        }

        if (!Enemy.Parameters.IsAlive)
        {
            return Result.WON;
        }
        
        return Result.NONE;
    }
}