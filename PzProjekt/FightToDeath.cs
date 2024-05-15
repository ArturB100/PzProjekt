namespace PzProjekt;

public class FightToDeath : Fight
{
    public FightToDeath(Character player, Character enemy) : base(player, enemy) { }
    
    public override Result CheckFightResult()
    {
        if (!Player.IsAlive)
        {
            return Result.LOST;
        }

        if (!Enemy.IsAlive)
        {
            return Result.WON;
        }
        
        return Result.NONE;
    }
}