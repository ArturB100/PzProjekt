﻿namespace PzProjekt;

public delegate void Action(Fight fight);

public class Effect : InventoryItem
{
    public Action OnEffectBegin;
    public Action OnEffectEnd;
    public Action ApplyEffect; 
    
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
        return ApplyEffect == Actions.Freeze;
    }

    public Effect(int minLevel, string name, int valueInGold, Action onEffectBegin, Action onEffectEnd, Action applyEffect) : base(minLevel, name, valueInGold)
    {
        OnEffectBegin = onEffectBegin;
        OnEffectEnd = onEffectEnd;
        ApplyEffect = applyEffect;
    }
}