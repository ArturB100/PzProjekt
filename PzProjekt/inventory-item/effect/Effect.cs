using System.Text.Json.Serialization;

namespace PzProjekt;

public delegate void EffectAction(Fight fight);

public class Effect : InventoryItem
{

    [JsonIgnore]
    public EffectAction? OnEffectBegin;
    [JsonIgnore]
    public EffectAction? OnEffectEnd;
    [JsonIgnore]
    public EffectAction? ApplyEffect;

    public string OnEffectBeginDelegateStr { get; set; }
    public string OnEffectEndDelegateStr { get; set; }
    public string ApplyEffectDelegateStr { get; set; }

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
        Duration = duration;

        if (onEffectBegin != null)
        {
            OnEffectBegin = onEffectBegin;
            OnEffectBeginDelegateStr = OnEffectBegin.Method.Name;
        }
        else
        {

        }
        if (onEffectEnd != null)
        {
            OnEffectEnd = onEffectEnd;
            OnEffectEndDelegateStr = OnEffectEnd.Method.Name;
        }
        if (applyEffect != null)
        {
            ApplyEffect = applyEffect;
            ApplyEffectDelegateStr = ApplyEffect.Method.Name;
        }
    }
}