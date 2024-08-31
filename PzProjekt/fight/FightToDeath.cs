using PzProjekt.fight;

namespace PzProjekt;

public class FightToDeath : Fight
{
    public FightToDeath(Character player, Character enemy, IBotAction? botAction) : base(player, enemy, botAction) { }
    
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