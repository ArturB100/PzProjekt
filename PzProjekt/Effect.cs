namespace PzProjekt;

public delegate void Action(Fight fight);

public class Effect
{
    public event Action OnEffectBegin;
    public event Action OnEffectEnd;
    public event Action ApplyEffect; 
    
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
}