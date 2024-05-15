﻿using PzProjekt.exceptions;

namespace PzProjekt;

public abstract class Fight
{
    public EnemyBehavior EnemyBehavior { get; set; }
    public CharacterFightActions CharacterFightActions { get; set; }
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
        
        activeCharacter = player;
        CharacterFightActions = new CharacterFightActions(this);
        EnemyBehavior = new EnemyBehavior(this);
    }

    private int CalcBaseCrowdSatisfaction()
    {
        return Convert.ToInt32(Player.CharacterStatistics.Charisma * 0.01 + Enemy.CharacterStatistics.Charisma * 0.01);
    }

    public abstract Result CheckFightResult();
    
    public void NextTurn()
    {
        changeActiveCharacter();
        
        Console.WriteLine("It's " + ActiveCharacter.Name + "'s turn!");
        
        if (ActiveCharacter.Effect != null && ActiveCharacter.Effect.Type != EffectType.NONE)
        {
            if(ActiveCharacter.Effect.TurnsLeft == 0)
            {
                Console.WriteLine("Effect " + ActiveCharacter.Effect.Type + " has ended!");
                ActiveCharacter.Effect = null;
            }
            else
            {
                ActiveCharacter.Effect.TurnsLeft--;
                Console.WriteLine("Turns left: " + ActiveCharacter.Effect.TurnsLeft);

                if (ActiveCharacter.Effect.Type == EffectType.FROZEN)
                {
                    Console.WriteLine(ActiveCharacter.Name + " is frozen!");
                    return;
                }
                
                ActiveCharacter.Effect.Trigger(this);
            }
        }
        
        if (ActiveCharacter.ActualStamina == 0)
        {
            CharacterFightActions.Sleep();
            return;
        }

        if (ActiveCharacter == Player)
        {
            waitForAction();
        }
        else
        {
            EnemyBehavior.MakeMove();
        }
    }

    private void waitForAction()
    {
        if (CharacterFightActions.IsAttackPossible())
        {
            Console.WriteLine("1. Strong Attack: " + CharacterFightActions.StrongAttackChance);
            Console.WriteLine("2. Medium Attack: " + CharacterFightActions.MediumAttackChance);
            Console.WriteLine("3. Weak Attack: " + CharacterFightActions.WeakAttackChance);
        }
        
        Console.WriteLine("4. Move Towards Enemy");
        Console.WriteLine("5. Move From Enemy");
        Console.WriteLine("6. Sleep");
        Console.WriteLine("7. Satisfy The Crowd");
        Console.WriteLine("8. Use Spell");
        
        Console.WriteLine("Choose action: ");
        int action;
        
        while (true)
        {
            try
            {
                action = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception e) {}
        }
        
        switch (action)
        {
            case 1:
                CharacterFightActions.Attack(AttackType.STRONG);
                break;
            case 2:
                CharacterFightActions.Attack(AttackType.MEDIUM);
                break;
            case 3:
                CharacterFightActions.Attack(AttackType.WEAK);
                break;
            case 4:
                CharacterFightActions.MoveTowardsEnemy();
                break;
            case 5:
                CharacterFightActions.MoveFromEnemy();
                break;
            case 6:
                CharacterFightActions.Sleep();
                break;
            case 7:
                CharacterFightActions.SatisfyTheCrowd();
                break;
            case 8:
                CharacterFightActions.UseSpell(ChooseSpell());
                break;
        }
    }

    private Spell ChooseSpell()
    {
        CharacterFightActions.ListSpells();
        
        int action;
        
        while (true)
        {
            try
            {
                action = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception e) {}
        }

        return ActiveCharacter.AvailableSpells[action];
    }
}