using PzProjekt.exceptions;

namespace PzProjekt;

public class CharacterParameters
{
    private Character _character;

    public CharacterParameters(Character character)
    {
        _character = character;
        MaxHP = CalculateMaxHp();
        ActualHP = MaxHP;
        MaxStamina = CalculateMaxStamina();
        ActualStamina = MaxStamina;
        Level = 1;
        Money = 2500;
    }
    
    public CharacterParameters(Character character, int level)
    {
        _character = character;
        MaxHP = CalculateMaxHp();
        ActualHP = MaxHP;
        MaxStamina = CalculateMaxStamina();
        ActualStamina = MaxStamina;
        Level = level;
    }
    
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }
    public int PointsToInvest { get; set; }
    public int MaxHP { get; set; }
    
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
            else
            {
                _actualHP = value;
            }
        }
    }
    public int MaxStamina { get; set; }
    
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
        return 100 + Level * 20 + _character.ActualStatistics.Vitality * 20;
    }

    private int CalculateMaxStamina()
    {
        return 100 + Level * 20 + _character.ActualStatistics.Stamina * 20;
    }
    
    public int PossibleDistance { get { return 20 + 4 * _character.ActualStatistics.Agility; } }
    
    private int _charcterMoney;
    public int Money
    {
        get => _charcterMoney;
        set
        {
            if (value < 0)
            {
                throw new NoEnoughMoneyException();
            }

            _charcterMoney = value;
        }
    }
    
    public int MinimalDamage
    {
        get => _character.Inventory.Weapon == null ? _character.ActualStatistics.Strength * 10 : _character.Inventory.Weapon.MinimalDamage + _character.ActualStatistics.Strength * 10;
    } 
        
    public int MaximalDamage
    {
        get => _character.Inventory.Weapon == null ? _character.ActualStatistics.Strength * 20 : _character.Inventory.Weapon.MaximalDamage + _character.ActualStatistics.Strength * 20;
    }

    public int AttackRange
    {
        get => 50 + 10 * _character.ActualStatistics.Agility;
    }

    private int _position;

    public int Position
    {
        get => _position;
        set
        {
            if (value < 0)
            {
                _position = 0;
            }
            else if (value > 1000)
            {
                _position = 1000;
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
        get => 1 + Level / 10;
    }
}