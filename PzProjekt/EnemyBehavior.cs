namespace PzProjekt;

public class EnemyBehavior
{
    private Fight fight;
    private Random random;

    public EnemyBehavior(Fight fight)
    {
        this.fight = fight;
        this.random = new Random();
    }

    public void MakeMove()
    {
        if (fight.Enemy.AttackRange > fight.DistanceBetweenCharacters)
        {
            AttackType attackType = (AttackType)random.Next(Enum.GetNames(typeof(AttackType)).Length);
            fight.AttackPlayer(attackType);
        }
        else
        {
            fight.MoveTowardsEnemy();
        }
    }
}