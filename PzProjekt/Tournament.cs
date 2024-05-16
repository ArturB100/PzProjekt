namespace PzProjekt;

public class Tournament
{
    public int MinimalLevel { get; set; }
    
    private Queue<Character> Enemies;
    
    private Character NextEnemy
    {
        get => Enemies.Dequeue();
    }
    
    public FightToDeath CreateNextFightToDeath(Character player)
    {
        return new FightToDeath(player, NextEnemy);
    }
}