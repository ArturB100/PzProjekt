namespace PzProjekt;

public delegate void Action(Fight fight);

public class Effect
{
    public event Action ApplyEffect; 
    public int TurnsLeft { get; set; }
    public EffectType Type { get; set; }

    public Effect(int turnsLeft, EffectType type)
    {
        TurnsLeft = turnsLeft;
        Type = type;
    }
    
    public void Trigger(Fight fight)
    {
        ApplyEffect?.Invoke(fight);
    }
}