namespace PzProjekt;


public class ActiveEffect
{
    public int TurnsLeft { get; set; }
    public event Effect Effect;
    private Character character;
    private Fight fight;

    public ActiveEffect(Character character, Fight fight, int turnsLeft, Effect effect)
    {
        this.character = character;
        this.fight = fight;
        TurnsLeft = turnsLeft;
        Effect = effect;
    }

    public void Trigger()
    {
        Effect.Invoke(character, fight);
        TurnsLeft--;
    }
}