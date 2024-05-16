namespace PzProjekt;

public class ActiveEffect
{
    public Effect Effect { get; set; }
    public int TurnsLeft { get; set; }
    
    public ActiveEffect(Effect effect, int turnsLeft, Fight fight)
    {
        Effect = effect;
        TurnsLeft = turnsLeft;
        effect.BeginEffect(fight);
    }
}