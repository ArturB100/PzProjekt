﻿using PzProjekt.exceptions;

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
    
    public int StrongAttackDamage
    {
        get
        {
            return Convert.ToInt32(DrawDamage() * 1.5);
        }
    }
    
    public double StrongAttackChance
    {
        get
        {
            Character attacker = ActiveCharacter;
            Character defender = InactiveCharacter;
            double chance = attacker.ActualStatistics.Attack / (double)defender.ActualStatistics.Defence * 0.5;

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
            
            double chance = attacker.ActualStatistics.Attack / (double)defender.ActualStatistics.Defence;
            
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
            
            double chance = attacker.ActualStatistics.Attack / (double)defender.ActualStatistics.Defence * 1.5;
            
            if (chance > 1)
            {
                chance = 1;
            }
            
            return chance;
        }
    }

    public double GetAttackChanceToHit (AttackType attackType)
    {
        AttackProperties attackProperties = new AttackProperties(attackType);
        return ActiveCharacter.ActualStatistics.Attack / (double)InactiveCharacter.ActualStatistics.Defence * attackProperties.ChanceMultiplier;
    }

    public void Attack(AttackType attackType)
    {
        Character attacker = ActiveCharacter;
        Character defender = InactiveCharacter;
        
        AttackProperties attackProperties = new AttackProperties(attackType);
        
        if (!IsAttackPossible(attackType))
        {
            throw new AttackNotPossibleException();
        }
        
        double probability = attacker.ActualStatistics.Attack / (double)defender.ActualStatistics.Defence * attackProperties.ChanceMultiplier;
        Random random = new Random();
        double chance = random.NextDouble();
        
        if (chance <= probability)
        {
            int damage = Convert.ToInt32(DrawDamage() * attackProperties.DamageMultiplier);
            TakeDamage(damage);

            if (attacker.Inventory.Weapon != null && attacker.Inventory.Weapon.Effect != null)
            {
                TryToUseEffect();
            }
        }
        else
        {
            Console.WriteLine(defender.Name + " dodged the attack!");
        }
        
        attacker.Parameters.ActualStamina -= attackProperties.NeededStamina;
    }
    
    public void TakeDamage(int damage)
    {
        CharacterInventory characterInventory = InactiveCharacter.Inventory;
        CharacterParameters characterParameters = InactiveCharacter.Parameters;
        
        if (characterInventory.ArmourSet.ActualArmorPoints == 0)
        {
            characterParameters.ActualHP -= damage;
                
            Console.WriteLine(InactiveCharacter.Name + " took " + damage + " damage!");
            Console.WriteLine("Actual " + InactiveCharacter.Name + " HP: " + characterParameters.ActualHP + " / " + characterParameters.MaxHP);
        }
        else
        {
            characterInventory.ArmourSet.ActualArmorPoints -= damage;
        }
    }
    
    private int DrawDamage()
    {
        Weapon weapon = ActiveCharacter.Inventory.Weapon;
        int minimalDamage = 0;
        int maximalDamage = 0;
        
        if (weapon != null)
        {
            minimalDamage = weapon.MinimalDamage;
            maximalDamage = weapon.MaximalDamage;
        }
        
        CharacterParameters characterParameters = ActiveCharacter.Parameters;
        
        return new Random().Next(minimalDamage + characterParameters.MinimalDamage, maximalDamage + characterParameters.MaximalDamage);
    }
    
    private void TryToUseEffect()
    {
        double probability = ActiveCharacter.ActualStatistics.Magica / (double)InactiveCharacter.ActualStatistics.Magica * 0.1;
        
        Console.WriteLine("Probability to use the effect: " + probability);
        
        Random random = new Random();
        double chance = random.NextDouble();

        if (chance <= probability)
        {
            Console.WriteLine("Effect used!");
            InactiveCharacter.ActiveEffect = new ActiveEffect(ActiveCharacter.Inventory.Weapon.Effect, Fight);
        }
    }
    
    public bool IsAttackPossible(AttackType attackType)
    {
        if (ActiveCharacter.Parameters.AttackRange <= Fight.DistanceBetweenCharacters)
        {
            return false;
        }
        
        if (ActiveCharacter.Parameters.ActualStamina < new AttackProperties(attackType).NeededStamina)
        {
            return false;
        }

        return true;
    }
    
    public void MoveTowardsEnemy()
    {
        if(InactiveCharacter.Parameters.Position < ActiveCharacter.Parameters.Position)
        {
            MoveLeft();
        }
        else
        {
            MoveRight();
        }
    }
    
    public void MoveFromEnemy()
    {
        if(InactiveCharacter.Parameters.Position < ActiveCharacter.Parameters.Position)
        {
            MoveRight();
        }
        else
        {
            MoveLeft();
        }
    }
    
    public void MoveLeft()
    {
        CharacterParameters characterParameters = ActiveCharacter.Parameters;
        int prevPos = characterParameters.Position;
        
        characterParameters.ActualStamina -= 20;
        characterParameters.Position -= characterParameters.PossibleDistance;
        if (ActiveCharacter == Fight.Player)
        {
            Fight.OnPlayerMove(prevPos, characterParameters.Position);
        } 
        else
        {
            Fight.OnEnemyMove(prevPos, characterParameters.Position);
        }
        Fight.Log("w lewo");
        
    }
        
    public void MoveRight()
    {
        CharacterParameters characterParameters = ActiveCharacter.Parameters;
        int prevPos = characterParameters.Position;

        characterParameters.ActualStamina -= 20;
        characterParameters.Position += characterParameters.PossibleDistance;
        if (ActiveCharacter == Fight.Player)
        {
            Fight.OnPlayerMove(prevPos, characterParameters.Position);
        }
        else
        {
            Fight.OnEnemyMove(prevPos, characterParameters.Position);
        }
        Fight.Log("w prawo");
    }
    
    public void Sleep()
    {
        ActiveCharacter.Parameters.ActualHP += ActiveCharacter.ActualStatistics.Stamina;
        ActiveCharacter.Parameters.ActualStamina += Convert.ToInt32(ActiveCharacter.Parameters.MaxStamina * 0.2);
        Fight.Log(ActiveCharacter.Name + " slept!");
    }
    
    public void SatisfyTheCrowd()
    {
        Fight.CrowdSatisfaction += ActiveCharacter.ActualStatistics.Charisma * 0.01;
    }

    public void ListSpells()
    {
        int counter = 0;
        ActiveCharacter.Inventory.AvailableSpells.ForEach(spell => Console.WriteLine(counter++ + ": " + spell.Name));
    }
    
    public void UseSpell(Spell spell)
    {
        spell.Use(Fight);
        ActiveCharacter.Inventory.AvailableSpells.Remove(spell);
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