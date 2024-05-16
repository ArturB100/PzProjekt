namespace PzProjekt;

public class EnemyBehavior
{
    private Fight _fight;
    private Random _random;

    public EnemyBehavior(Fight fight)
    {
        this._fight = fight;
        this._random = new Random();
    }

    public void MakeMove()
    {
        if (_fight.Enemy.Parameters.AttackRange > _fight.DistanceBetweenCharacters)
        {
            AttackType attackType = (AttackType)_random.Next(Enum.GetNames(typeof(AttackType)).Length);
            _fight.CharacterFightActions.Attack(attackType);
        }
        else
        {
            _fight.CharacterFightActions.MoveTowardsEnemy();
        }
    }
}