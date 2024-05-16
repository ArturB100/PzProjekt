
using PzProjekt;

namespace ConsoleApp
{
    internal static class Program
    {
        static void Main()
        {
            Character player = CharacterFactory.createRandomCharacterBasedOnLevel(1);
            Character enemy = CharacterFactory.createRandomCharacterBasedOnLevel(1);

            player.ActualStatistics.Magica = 100;
            player.ActualStatistics.Attack = 100;
            
            enemy.ActualStatistics.Magica = 1;
            
            CharacterStatistics playerStatistics = player.ActualStatistics;
            
            List<Spell> spells = new List<Spell>
            {
                new Spell(1, "Teleportation", 2149, Spells.Teleport),
                new Spell(1, "Gale", 3820, Spells.Gale),
                new Spell(1, "Adulation", 15280,Spells.Adulation),
                new Spell(1, "Command", 15280, Spells.Command),
                new Spell(1, "Ghost Strike", 105289, Spells.GhostStrike),
                new Spell(1, "Weaken Armor", 115555, Spells.WeakenArmor),
                new Spell(1, "Rejuvinate", 188000, Spells.Rejuvinate),
                new Spell(1, "Fireball", 19857, Spells.Fireball),
            };

            List<Effect> effects = new List<Effect>
            {
                new Effect(1, "Freeze", 1000, null, null, Actions.Freeze),
                new Effect(1, "Weakness", 1000, Actions.BeginWeakness, Actions.EndWeakness, null),
                new Effect(1, "Poison", 1000, null, null, Actions.Poison),
            };
            
            // player.Inventory.AddSpell(teleportation);
            // player.Inventory.AddSpell(fireball);
            //
            Weapon sword = new Weapon(1, "", 1, null, WeaponType.Sword, 10, 20);
            
            
            
            sword.Effect = effects[1];
            
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