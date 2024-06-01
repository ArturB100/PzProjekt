
using PzProjekt;
using System.Runtime.InteropServices;

namespace WinForm
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(uint dwProcessId);

        private const uint ATTACH_PARENT_PROCESS = 0xFFFFFFFF;

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            AttachConsole(ATTACH_PARENT_PROCESS);  // Attach console to parent process
            Console.WriteLine("Console attached. Logging starts here.");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new ProgramCtx());


  

        }
    }
}