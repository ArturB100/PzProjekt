
using PzProjekt;

namespace WinForm
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // ApplicationConfiguration.Initialize();
            //
            // Application.Run(new Form1());

            Character player = CharacterFactory.createRandomCharacterBasedOnLevel(1);
            Character enemy = CharacterFactory.createRandomCharacterBasedOnLevel(1);

            Spell teleportation = new Spell();
            teleportation.Name = "Teleportation";
            teleportation.OnUse += Spells.Teleport;
            
            Spell fireball = new Spell();
            fireball.Name = "Fireball";
            fireball.OnUse += Spells.Fireball;
            
            player.AddSpell(teleportation);
            player.AddSpell(fireball);
            
            Sword sword = new Sword(10, 20, EffectType.FROZEN);

            player.EquipedWeapon = sword;
            
            Console.WriteLine("Player: " + player.Name);
            Console.WriteLine("Enemy: " + enemy.Name);
            
            var fight = new FightToDeath(player, enemy);

            while (fight.CheckFightResult() == Result.NONE)
            {
                fight.NextTurn();
            }
            
            Console.WriteLine(fight.CheckFightResult());
        }
    }
}