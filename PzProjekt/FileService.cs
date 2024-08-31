using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public static class FileService
    {
        

        public static void WriteToFile(int result ,params int[] inputs)
        {
            using (StreamWriter writer = new StreamWriter("logs", true))
            {
                writer.Write(result.ToString());
                writer.Write(" ; ");
                foreach (var input in inputs)
                {
                    writer.Write(input + " ");
                }
                writer.WriteLine();
            }
        }
    }
}
