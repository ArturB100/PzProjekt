using PzPro

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GameSaverService.SerializeToJson(new Character()));
        }
    }
}
