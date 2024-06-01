using PzProjekt.exceptions;
using System;
using System.Diagnostics;

namespace PzProjekt;


public delegate int OnPlayerTurn();
public delegate void OnCharacterMove(int prevPos, int nextPos);
public delegate void OnCharacterHPChange(Character character);
public delegate void OnActionDispatched(string msg);
public abstract class Fight
{
    private const int InitialPlayerPosition = 450;
    private const int InitialEnemyPosition = 550;
    
    public EnemyBehavior EnemyBehavior { get; set; }
    public CharacterFightActions CharacterFightActions { get; set; }
    private Character activeCharacter;


    // delegates
    public OnPlayerTurn OnPlayerTurn;
    protected OnCharacterMove onPlayerMove;
    protected OnCharacterMove onEnemyMove;
    public event OnActionDispatched onActionDispatched;

    public void ChangeActiveCharacterPosition(int newPosition)
    {
        int oldPosition = ActiveCharacter.Parameters.Position;
        ActiveCharacter.Parameters.Position = newPosition;

        if (ActiveCharacter == Player)
        {
            onPlayerMove?.Invoke(oldPosition, newPosition);
        }
        else
        {
            onEnemyMove?.Invoke(oldPosition, newPosition);
        }
    }
    
    public void ChangeInactiveCharacterPosition(int newPosition)
    {
        int oldPosition = InactiveCharacter.Parameters.Position;
        InactiveCharacter.Parameters.Position = newPosition;

        if (InactiveCharacter == Player)
        {
            onPlayerMove?.Invoke(oldPosition, newPosition);
        }
        else
        {
            onEnemyMove?.Invoke(oldPosition, newPosition);
        }
    }
    
    public OnCharacterMove OnPlayerMove  
    {
        get { return onPlayerMove; }
    }

    public OnCharacterMove OnEnemyMove 
    {
        get {  return onEnemyMove; }
    }

    public void SetOnPlayerMove (OnCharacterMove onCharacterMove)
    {
        this.onPlayerMove = onCharacterMove;
    }

    public void SetOnEnemyMove(OnCharacterMove onCharacterMove)
    {
        this.onEnemyMove = onCharacterMove;
    }

    private Character _activeCharacter;
    public Character ActiveCharacter
    {
        get => _activeCharacter;
    }
    
    public Character InactiveCharacter
    {
        get => _activeCharacter == Player ? Enemy : Player;
    }
    
    private void ChangeActiveCharacter()
    {
        _activeCharacter = _activeCharacter == Player ? Enemy : Player;
    }
    
    public Character Player { get; set; }
    public Character Enemy { get; set; }
    public int CrowdSatisfaction { get; set; }
    
    public int ExperiencePointsToGet
    {
        get => 1000 * (1 + Math.Abs(Enemy.Parameters.Level / Player.Parameters.Level));
    }
    
    public int MoneyToGet
    {
        get => 1000 * (Player.Parameters.Level * Math.Abs(Player.Parameters.Level / Enemy.Parameters.Level)) * (1 + CrowdSatisfaction);
    }
    
    public int MoneyToLose
    {
        get => 250 * (1 + Math.Abs(Player.Parameters.Level - Enemy.Parameters.Level));
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
        
        Console.WriteLine(player.Parameters.MaxStamina);
        
        player.Parameters.ActualStamina = player.Parameters.MaxStamina;
        
        player.Parameters.Position = InitialPlayerPosition;
        enemy.Parameters.Position = InitialEnemyPosition;
        
        _activeCharacter = player;
        CharacterFightActions = new CharacterFightActions(this);
        EnemyBehavior = new EnemyBehavior(this);
        CrowdSatisfaction = CalcBaseCrowdSatisfaction();
    }

    private int CalcBaseCrowdSatisfaction()
    {
        return Convert.ToInt32(Player.BaseStatistics.Charisma * 0.01 + Enemy.BaseStatistics.Charisma * 0.01);
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

    public void Log (string msg)
    {
        onActionDispatched?.Invoke(msg);
    }
    
    public void NextTurn()
    {
        
        Console.WriteLine("It's " + ActiveCharacter.Name + "'s turn!");
        
        if (ActiveCharacter.ActiveEffect != null)
        {
            if(ActiveCharacter.ActiveEffect.TurnsLeft == 0)
            {
                Console.WriteLine("Effect has ended!");
            }
            else
            {
                Console.WriteLine("Effect is still active!");
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
        }
        else if (ActiveCharacter == Player)
        {
            Log("ruch gracza \n");
            int moveChoosenByPlayer = OnPlayerTurn.Invoke();
            DoAction(moveChoosenByPlayer);
        }
        else
        {
            Log("ruch przeciwnika");
            EnemyBehavior.MakeMove();
        }

        ChangeActiveCharacter();

    }

    private void DoAction (int actionNo)
    {
        switch (actionNo)
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
   
    private void waitForAction()
    {
        if (CharacterFightActions.IsAttackPossible(AttackType.STRONG))
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