
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
            
            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon(1, "Dagger", 1285, WeaponType.Sword, 3, 9),
                new Weapon(1, "Shortsword", 2270, WeaponType.Sword, 4, 16),
                new Weapon(1, "Dirk", 3535, WeaponType.Sword, 5, 25),
                new Weapon(1, "Gladius", 5078, WeaponType.Sword, 6, 36),
                new Weapon(1, "Broadsword", 6901, WeaponType.Sword, 7, 49),
            };
            
            Character player = CharacterFactory.createRandomCharacterBasedOnLevel(1);
            Character enemy = CharacterFactory.createRandomCharacterBasedOnLevel(1);

            player.BaseStatistics.Magica = 100;
            player.BaseStatistics.Attack = 100;
            
            enemy.BaseStatistics.Magica = 1;
            
            Spell teleportation = new Spell(1, "Teleportation", 1000);
            teleportation.Name = "Teleportation";
            teleportation.OnUse += Spells.Teleport;
            
            Spell fireball = new Spell(1, "Fireball", 1000);
            fireball.Name = "Fireball";
            fireball.OnUse += Spells.Fireball;
            
            player.Inventory.AddSpell(teleportation);
            player.Inventory.AddSpell(fireball);
            
            Weapon sword = new Weapon(1, "", 1, WeaponType.Sword, 10, 20);
            
            Effect frozen = new Effect();
            frozen.ApplyEffect += Actions.Freeze;
            
            Effect weakness = new Effect();
            weakness.OnEffectBegin += Actions.BeginWeakness;
            weakness.OnEffectEnd += Actions.EndWeakness;
            
            sword.Effect = weakness;
            
            player.Inventory.Weapon = sword;
            
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