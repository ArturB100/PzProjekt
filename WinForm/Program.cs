using PzProjekt;

namespace WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var player = CharacterFactory.createRandomCharacterBasedOnLevel(1);
            var enemy = CharacterFactory.createRandomCharacterBasedOnLevel(1);
            
            var fight = new Fight(player, enemy);
            
            fight.attackEnemy();
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());
        }
    }
}