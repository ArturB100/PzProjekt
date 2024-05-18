namespace PzProjekt;

public class ActiveEffect
{
    public Effect Effect { get; set; }
    public int TurnsLeft { get; set; }
    
    public ActiveEffect(Effect effect, Fight fight)
    {
        Effect = effect;
        TurnsLeft = Effect.Duration;
        effect.BeginEffect(fight);
    }
}