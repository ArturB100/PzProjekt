using PzProjekt.exceptions;

namespace PzProjekt;

public class InventoryItemBasedOnLevel : InventoryItem
{
    public int MinLevel { get; set; }

    public InventoryItemBasedOnLevel(string name, int valueInGold, int minLevel) : base(name, valueInGold)
    {
        MinLevel = minLevel;
    }

    public override bool CanBeBoughtByPlayer(Character character)
    {
        bool canBeBoughtByPlayer = base.CanBeBoughtByPlayer(character);

        if(character.Parameters.Level < MinLevel)
        {
            throw new TooWeakLevelException();
        }

        return canBeBoughtByPlayer;
    }
}