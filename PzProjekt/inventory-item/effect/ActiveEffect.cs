namespace PzProjekt;

public class ActiveEffect
{
    public Effect Effect { get; set; }
    public int TurnsLeft { get; set; }
    
    public ActiveEffect(Effect effect)
    {
        Effect = effect;
        TurnsLeft = Effect.Duration;
    }
}