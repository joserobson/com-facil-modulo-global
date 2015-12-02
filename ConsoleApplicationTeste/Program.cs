using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var phoneBookRunner = new ModuloGlobalRunner())
            {
                phoneBookRunner.Start();                
            }
        }
    }
}
