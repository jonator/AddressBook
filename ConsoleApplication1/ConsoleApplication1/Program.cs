using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMyName("Habeebansgaradasbad III");
            string name = GetName();
            WriteMyName(name);
            Console.Read();
        }

        static void WriteMyName(string name)
        {
            Console.WriteLine(name);
        }
        static string GetName()
        {
            return "Habeebansgaradasbad I";
        }
        

    }
}
