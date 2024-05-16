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
}