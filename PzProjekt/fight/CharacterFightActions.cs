using PzProjekt.exceptions;

namespace PzProjekt;

public class CharacterFightActions
{
    public Fight Fight { get; set; }
    public Character ActiveCharacter { get => Fight.ActiveCharacter; }
    public Character InactiveCharacter { get => Fight.InactiveCharacter; }

    public CharacterFightActions(Fight fight)
    {
        Fight = fight;
    }

    public double StrongAttackChance
    {
        get
        {
            Character attacker = ActiveCharacter;
            Character defender = InactiveCharacter;
            double chance = attacker.CharacterStatistics.Attack / (double)defender.CharacterStatistics.Defence * 0.5;

            if (chance > 1)
            {
                chance = 1;
            }
            
            return chance;
        }
    }
    
    public double MediumAttackChance
    {
        get
        {
            Character attacker = ActiveCharacter;
            Character defender = InactiveCharacter;
            
            double chance = attacker.CharacterStatistics.Attack / (double)defender.CharacterStatistics.Defence;
            
            if (chance > 1)
            {
                chance = 1;
            }
            
            return chance;
        }
    }
    
    public double WeakAttackChance
    {
        get
        {
            Character attacker = ActiveCharacter;
            Character defender = InactiveCharacter;
            
            double chance = attacker.CharacterStatistics.Attack / (double)defender.CharacterStatistics.Defence * 1.5;
            
            if (chance > 1)
            {
                chance = 1;
            }
            
            return chance;
        }
    }

    public void Attack(AttackType attackType)
    {
        Character attacker = ActiveCharacter;
        Character defender = InactiveCharacter;
        
        AttackProperties attackProperties = new AttackProperties(attackType);
        
        if (!IsAttackPossible())
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

            if (attacker.EquipedWeapon.EffectType != EffectType.NONE)
            {
                TryToUseEffect();
            }
        }
        else
        {
            Console.WriteLine(defender.Name + " dodged the attack!");
        }
        
        attacker.ActualStamina -= attackProperties.NeededStamina;
    }

    private void TryToUseEffect()
    {
        double probability = ActiveCharacter.CharacterStatistics.Magica / (double)InactiveCharacter.CharacterStatistics.Magica * 0.1;
        
        Console.WriteLine("Probability to use the effect: " + probability);
        
        Random random = new Random();
        double chance = random.NextDouble();

        if (chance <= probability)
        {
            Console.WriteLine("Effect used!");
            InactiveCharacter.Effect = new Effect(3, ActiveCharacter.EquipedWeapon.EffectType);
        }
    }
    
    public bool IsAttackPossible()
    {
        if (ActiveCharacter.AttackRange <= Fight.DistanceBetweenCharacters)
        {
            return false;
        }
        
        return true;
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
    
    public void MoveFromEnemy()
    {
        if(InactiveCharacter.Position < ActiveCharacter.Position)
        {
            ActiveCharacter.MoveRight();
        }
        else
        {
            ActiveCharacter.MoveLeft();
        }
    }

    public void Sleep()
    {
        ActiveCharacter.ActualStamina += Convert.ToInt32(ActiveCharacter.MaxStamina * 0.2);
        Console.WriteLine(ActiveCharacter.Name + " slept!");
    }
    
    public void SatisfyTheCrowd()
    {
        Fight.CrowdSatisfacion += Convert.ToInt32(ActiveCharacter.CharacterStatistics.Charisma * 0.01);
    }

    public void ListSpells()
    {
        int counter = 0;
        ActiveCharacter.AvailableSpells.ForEach(spell => Console.WriteLine(counter++ + ": " + spell.Name));
    }
    
    public void UseSpell(Spell spell)
    {
        spell.Use(Fight);
        ActiveCharacter.AvailableSpells.Remove(spell);
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