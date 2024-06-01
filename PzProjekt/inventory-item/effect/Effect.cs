namespace PzProjekt;

public delegate void EffectAction(Fight fight);

public class Effect : InventoryItem
{
    public EffectAction ApplyEffect; 
    
    public int Duration { get; set; }
    
    public void Trigger(Fight fight)
    {
        ApplyEffect?.Invoke(fight);
    }
    
    public bool IsFrozen()
    {
        return ApplyEffect == Effects.Freeze;
    }

    public Effect(string name, int valueInGold, EffectAction applyEffect, int duration) : base(name, valueInGold)
    {
        ApplyEffect = applyEffect;
        Duration = duration;
    }
}