using PzProjekt.exceptions;

namespace PzProjekt;

public class InventoryItemBasedOnStatistics : InventoryItem
{
    public CharacterStatistics MinimalStatistics { get; set; }

    public InventoryItemBasedOnStatistics(string name, int valueInGold, CharacterStatistics minimalStatistics) : base(name, valueInGold)
    {
        MinimalStatistics = minimalStatistics;
    }
    
    public override bool CanBeBoughtByPlayer(Character character)
    {
        bool canBeBoughtByPlayer = base.CanBeBoughtByPlayer(character);
        
        if (!character.BaseStatistics.IsGreater(MinimalStatistics))
        {
            throw new TooWeakStatisticsException();
        }

        return canBeBoughtByPlayer;
    }
}