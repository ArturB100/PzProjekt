using PzProjekt.exceptions;

namespace PzProjekt;

public class CharacterParameters
{
    private const int MinimalPosition = 0;
    private const int MaximalPosition = 1000;
    
    private const int BaseMaxHp = 20;
    private const int MaxHpVitalityMultiplier = 20;
    private const int MaxHpLevelMultiplier = 10;
    
    private const int BaseMaxStamina = 100;
    private const int MaxStaminaStaminaMultiplier = 10;
    
    private const int BasePossibleDistance = 20;
    private const int PossibleDistanceAgilityMultiplier = 4;
    
    private const int BaseMoney = 2500;
    
    private const int BaseMaxSpells = 1;
    private const int MaxSpellsPerLevel = 1;
    
    private Character _character;

    public CharacterParameters(Character character)
    {
        _character = character;
        MaxHP = CalculateMaxHp();
        ActualHP = MaxHP;
        ActualStamina = MaxStamina;
        Level = 1;
        Money = BaseMoney;
    }
    
    public CharacterParameters(Character character, int level)
    {
        _character = character;
        MaxHP = CalculateMaxHp();
        ActualHP = MaxHP;
        ActualStamina = MaxStamina;
        Level = level;
    }
    
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }
    public int PointsToInvest { get; set; }
    public int MaxHP { get; }
    
    private int _actualHP;
    public int ActualHP
    {
        get => _actualHP;
        set
        {
            if (value < 0)
            {
                _actualHP = 0;
            } 
            else if (value > MaxHP)
            {
                _actualHP = MaxHP;
            }
            else
            {
                _actualHP = value;
            }
        }
    }
    public int MaxStamina { get => CalculateMaxStamina(); }
    
    private int _actualStamina;
    public int ActualStamina
    {
        get => _actualStamina;
        set
        {
            if (value < 0)
            {
                _actualStamina = 0;
            }
            else if (value > MaxStamina)
            {
                _actualStamina = MaxStamina;
            }
            else
            {
                _actualStamina = value;
            }
        }
    }
    
    private int CalculateMaxHp()
    {
        return BaseMaxHp + Level * MaxHpLevelMultiplier + _character.BaseStatistics.Vitality * MaxHpVitalityMultiplier;
    }

    private int CalculateMaxStamina()
    {
        Console.WriteLine(_character.BaseStatistics.Stamina);
        
        return BaseMaxStamina + _character.BaseStatistics.Stamina * MaxStaminaStaminaMultiplier;
    }
    
    public int PossibleDistance { get { return BasePossibleDistance + PossibleDistanceAgilityMultiplier * _character.BaseStatistics.Agility; } }
    
    private int _charcterMoney;
    public int Money
    {
        get => _charcterMoney;
        set
        {
            if (value < 0)
            {
                _charcterMoney = 0;
            }

            _charcterMoney = value;
        }
    }
    
    public int MinimalDamage
    {
        get => _character.Inventory.Weapon == null ? _character.BaseStatistics.Strength + Level : _character.Inventory.Weapon.MinimalDamage + _character.BaseStatistics.Strength + Level;
    } 
        
    public int MaximalDamage
    {
        get => _character.Inventory.Weapon == null ? _character.BaseStatistics.Strength + Level + 2 : _character.Inventory.Weapon.MaximalDamage + _character.BaseStatistics.Strength + Level + 2;
    }

    public int AttackRange
    {
        get => BasePossibleDistance + PossibleDistanceAgilityMultiplier * _character.BaseStatistics.Agility;
    }

    private int _position;

    public int Position
    {
        get => _position;
        set
        {
            if (value < MinimalPosition)
            {
                _position = MinimalPosition;
            }
            else if (value > MaximalPosition)
            {
                _position = MaximalPosition;
            }
            else
            {
                _position = value;
            }
        }
    }
    
    public bool IsAlive 
    {
        get => ActualHP > 0;
    }
    
    public void Refill()
    {
        ActualHP = MaxHP;
        ActualStamina = MaxStamina;
    }
    
    public int MaxSpells
    {
        get => BaseMaxSpells + Level / MaxSpellsPerLevel;
    }
}