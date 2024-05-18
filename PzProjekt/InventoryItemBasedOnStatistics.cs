namespace PzProjekt;

public class InventoryItemBasedOnStatistics : InventoryItem
{
    public CharacterStatistics MinimalStatistics { get; set; }

    public InventoryItemBasedOnStatistics(string name, int valueInGold, CharacterStatistics minimalStatistics) : base(name, valueInGold)
    {
        MinimalStatistics = minimalStatistics;
    }
}