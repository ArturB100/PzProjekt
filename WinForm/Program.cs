
using PzProjekt;

namespace WinForm
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            Application.Run(new ProgramCtx());


  

        }
    }
}