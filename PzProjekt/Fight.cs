namespace PzProjekt;

public class Fight
{
    public Character Player { get; set; }
    public Character Enemy { get; set; }

    public Fight(Character player, Character enemy)
    {
        Player = player;
        Enemy = enemy;
    }

    public void attackEnemy()
    {
        attack(Player, Enemy);
    }
    
    public void attackPlayer()
    {
        attack(Enemy, Player);
    }
    
    private void attack(Character attacker, Character defender)
    {
        double probability = attacker.CharacterStatistics.Attack / (double)defender.CharacterStatistics.Defence;
        Random random = new Random();
        double chance = random.NextDouble();
        
        if (chance <= probability)
        {
            int damage = random.Next(attacker.MinimalDamage, attacker.MaximalDamage);
            defender.takeDamage(damage);
        }
    }
}