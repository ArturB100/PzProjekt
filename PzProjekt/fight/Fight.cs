using PzProjekt.exceptions;

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
    
    private void ChangeActiveCharacter()
    {
        activeCharacter = activeCharacter == Player ? Enemy : Player;
    }
    
    public Character Player { get; set; }
    public Character Enemy { get; set; }
    public int CrowdSatisfaction { get; set; }
    
    public int ExperiencePointsToGet
    {
        get => 1000 * (1 + Math.Abs(Player.Parameters.Level - Enemy.Parameters.Level));
    }
    
    public int MoneyToGet
    {
        get => 100 * (1 + Math.Abs(Player.Parameters.Level - Enemy.Parameters.Level)) * (1 + CrowdSatisfaction);
    }
    
    public int MoneyToLose
    {
        get => 50 * (1 + Math.Abs(Player.Parameters.Level - Enemy.Parameters.Level));
    }
    
    public int DistanceBetweenCharacters
    {
        get { return Math.Abs(Player.Parameters.Position - Enemy.Parameters.Position); }
    }
    
    public Fight(Character player, Character enemy)
    {
        Player = player;
        Enemy = enemy;
        
        player.Refill();
        enemy.Refill();
        
        player.Parameters.Position = 450;
        enemy.Parameters.Position = 550;
        
        activeCharacter = player;
        CharacterFightActions = new CharacterFightActions(this);
        EnemyBehavior = new EnemyBehavior(this);
        CrowdSatisfaction = CalcBaseCrowdSatisfaction();
    }

    private int CalcBaseCrowdSatisfaction()
    {
        return Convert.ToInt32(Player.ActualStatistics.Charisma * 0.01 + Enemy.ActualStatistics.Charisma * 0.01);
    }

    public abstract Result CheckFightResult();
    
    public void EndFight(Result result)
    {
        if (result == Result.WON)
        {
            Player.Parameters.Money += MoneyToGet;
            Player.Parameters.ExperiencePoints += ExperiencePointsToGet;
            int oldLevel = Player.Parameters.Level;
            Player.Parameters.Level = Player.Parameters.ExperiencePoints / 1000;
            if(oldLevel != Player.Parameters.Level)
            {
                Player.Parameters.PointsToInvest += 5;
            }
        }
        else if(result == Result.LOST)
        {
            Player.Parameters.Money -= MoneyToLose;
        }
    } 
    
    public void NextTurn()
    {
        ChangeActiveCharacter();
        
        Console.WriteLine("It's " + ActiveCharacter.Name + "'s turn!");
        
        if (ActiveCharacter.ActiveEffect != null)
        {
            if(ActiveCharacter.ActiveEffect.TurnsLeft == 0)
            {
                Console.WriteLine("Effect has ended!");
                ActiveCharacter.ActiveEffect.Effect.EndEffect(this);
                ActiveCharacter.ActiveEffect = null;
            }
            else
            {
                ActiveCharacter.ActiveEffect.TurnsLeft--;
                Console.WriteLine("Turns left: " + ActiveCharacter.ActiveEffect.TurnsLeft);

                if (ActiveCharacter.ActiveEffect.Effect.IsFrozen())
                {
                    Console.WriteLine(ActiveCharacter.Name + " is frozen!");
                    return;
                }
                
                ActiveCharacter.ActiveEffect.Effect.Trigger(this);
            }
        }
        
        if (ActiveCharacter.Parameters.ActualStamina == 0)
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

        return ActiveCharacter.Inventory.AvailableSpells[action];
    }
}