using PzProjekt.fight;

namespace PzProjekt;

public class EnemyBehavior
{
    private Fight _fight;
    private Random _random;

    public EnemyBehavior(Fight fight)
    {
        _fight = fight;
        _random = new Random();
    }

    public void MakeMove(IBotAction? botAction)
    {
        if (botAction != null)
        {
            botAction.MakeMove(_fight);
            return;
        }

        if (_fight.Enemy.Inventory.AvailableSpells.Count > 0 && _random.Next(4) == 0)
        {
            Spell spell = _fight.Enemy.Inventory.AvailableSpells[_random.Next(_fight.Enemy.Inventory.AvailableSpells.Count)];
            _fight.CharacterFightActions.UseSpell(spell);
        }
        else if (_fight.Enemy.Parameters.ActualHP < _fight.Player.Parameters.MinimalDamage && 
                 _fight.Player.Parameters.AttackRange < _fight.DistanceBetweenCharacters)
        {
            _fight.CharacterFightActions.Sleep();
        }
        else if (_fight.Enemy.Parameters.ActualHP < _fight.Player.Parameters.MinimalDamage && 
                 _fight.Player.Parameters.AttackRange > _fight.DistanceBetweenCharacters && 
                 _fight.Player.Parameters.AttackRange + _fight.DistanceBetweenCharacters < _fight.Player.Parameters.PossibleDistance)
        {
            _fight.CharacterFightActions.MoveFromEnemy();
        }
        else if (_fight.Enemy.Parameters.AttackRange > _fight.DistanceBetweenCharacters)
        {
            if (_fight.Enemy.Parameters.ActualStamina < 50)
            {
                _fight.CharacterFightActions.Sleep();
                return;
            }

            AttackType attackType = _fight.CharacterFightActions.IsAttackPossible(AttackType.STRONG) ? AttackType.STRONG : _fight.CharacterFightActions.IsAttackPossible(AttackType.MEDIUM) ? AttackType.MEDIUM : AttackType.WEAK;
            bool success = false;
            while (!success)
            {
                try
                {
                    _fight.CharacterFightActions.Attack(attackType);
                    success = true;
                }
                catch
                {
                    attackType = (AttackType)_random.Next(Enum.GetNames(typeof(AttackType)).Length);
                }
            }
        }
        else
        {
            _fight.CharacterFightActions.MoveTowardsEnemy();
        }
    }
}