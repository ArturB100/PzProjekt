namespace PzProjekt;

public delegate void Effect(Character enemy, Fight fight);

public class Effects
{
    public void Fire(Character character, Fight fight)
    {
        character.ActualHP -= 10;
    }

    public void Freeze(Character character, Fight fight)
    {
        fight.changeActiveCharacter();
    }
}