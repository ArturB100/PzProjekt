using PzProjekt.exceptions;

namespace PzProjekt;

public abstract class Fight
{
    private Character activeCharacter;
    public Character ActiveCharacter
    {
        get => activeCharacter;
    }
    
    public Character InactiveCharacter
    {
        get => activeCharacter == Player ? Enemy : Player;
    }
    
    public void changeActiveCharacter()
    {
        activeCharacter = activeCharacter == Player ? Enemy : Player;
    }
    
    public Character Player { get; set; }
    public Character Enemy { get; set; }
    public int CrowdSatisfacion { get; set; }
    
    public int ExperiencePointsToGet
    {
        get => 1000 * (1 + Math.Abs(Player.Level - Enemy.Level));
    }
    
    public int MoneyToGet
    {
        get => 100 * (1 + Math.Abs(Player.Level - Enemy.Level)) * (1 + CrowdSatisfacion);
    }
    
    public int MoneyToLose
    {
        get => 50 * (1 + Math.Abs(Player.Level - Enemy.Level));
    }
    
    public int DistanceBetweenCharacters
    {
        get { return Math.Abs(Player.Position - Enemy.Position); }
    }
    
    public Fight(Character player, Character enemy)
    {
        Player = player;
        Enemy = enemy;
        
        player.Refill();
        enemy.Refill();
        
        player.Position = 450;
        enemy.Position = 550;
    }

    private int CalcBaseCrowdSatisfaction()
    {
        return Convert.ToInt32(Player.CharacterStatistics.Charisma * 0.01 + Enemy.CharacterStatistics.Charisma * 0.01);
    }
    
    public void AttackEnemy(AttackType attackType)
    {
        Attack(Player, Enemy, attackType);
    }
    
    public void AttackPlayer(AttackType attackType)
    {
        Attack(Enemy, Player, attackType);
    }
    
    private void Attack(Character attacker, Character defender, AttackType attackType)
    {
        AttackProperties attackProperties = new AttackProperties(attackType);
        
        if (!IsAttackPossible(attacker, attackProperties.NeededStamina))
        {
            throw new AttackNotPossibleException();
        }
        
        double probability = attacker.CharacterStatistics.Attack / (double)defender.CharacterStatistics.Defence * attackProperties.ChanceMultiplier;
        Random random = new Random();
        double chance = random.NextDouble();
        
        if (chance <= probability)
        {
            int damage = Convert.ToInt32(attacker.drawDamage() * attackProperties.DamageMultiplier);
            defender.takeDamage(damage);
            attacker.EquipedWeapon.TriggerSpecialAttack(defender, this);
            attacker.ActualStamina -= attackProperties.NeededStamina;
        }
    }

    public abstract Result CheckFightResult();
    
    public bool IsAttackPossible(Character character, int neededStamina)
    {
        if (character.ActualStamina < neededStamina)
        {
            return false;
        }
        
        if (character.AttackRange <= DistanceBetweenCharacters)
        {
            return false;
        }
        
        return true;
    }
    
    public void NextTurn(Character character)
    {
        changeActiveCharacter();
        ActiveCharacter.ActiveEffects.ForEach(effect => effect.Trigger());
        
        if (character.ActualStamina == 0)
        {
            character.Sleep();
            return;
        }
    }

    private void SatisfyTheCrowd(Character character)
    {
        CrowdSatisfacion += Convert.ToInt32(character.CharacterStatistics.Charisma * 0.01);
    }

    public void MoveTowardsEnemy()
    {
        if(InactiveCharacter.Position < ActiveCharacter.Position)
        {
            ActiveCharacter.MoveLeft();
        }
        else
        {
            ActiveCharacter.MoveRight();
        }
    }
    
    private class AttackProperties
    {
        public double DamageMultiplier { get; set; }
        public double ChanceMultiplier { get; set; }
        public int NeededStamina { get; set; }

        public AttackProperties(AttackType attackType)
        {
            switch (attackType)
            {
                case AttackType.STRONG:
                    DamageMultiplier = 1.5;
                    ChanceMultiplier = 0.5;
                    NeededStamina = 150;
                    break;
                case AttackType.MEDIUM:
                    DamageMultiplier = 1;
                    ChanceMultiplier = 1;
                    NeededStamina = 100;
                    break;
                case AttackType.WEAK:
                    DamageMultiplier = 0.5;
                    ChanceMultiplier = 1.5;
                    NeededStamina = 50;
                    break;
            }
        }
    }
}