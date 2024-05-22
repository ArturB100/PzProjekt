namespace PzProjekt;

public delegate void EffectAction(Fight fight);

public class Effect : InventoryItem
{
    public EffectAction OnEffectBegin;
    public EffectAction OnEffectEnd;
    public EffectAction ApplyEffect; 
    
    public int Duration { get; set; }
    
    public void BeginEffect(Fight fight)
    {
        OnEffectBegin?.Invoke(fight);
    }
    
    public void EndEffect(Fight fight)
    {
        OnEffectEnd?.Invoke(fight);
    }
    
    public void Trigger(Fight fight)
    {
        ApplyEffect?.Invoke(fight);
    }
    
    public bool IsFrozen()
    {
        return ApplyEffect == Effects.Freeze;
    }

    public Effect(string name, int valueInGold, EffectAction onEffectBegin, EffectAction onEffectEnd, EffectAction applyEffect, int duration) : base(name, valueInGold)
    {
        OnEffectBegin = onEffectBegin;
        OnEffectEnd = onEffectEnd;
        ApplyEffect = applyEffect;
        Duration = duration;
    }
}