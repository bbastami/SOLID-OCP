using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor p = new Processor();
            p.process("Json"); // p.process("XML");

            Console.ReadKey(true);
        }
    }
}
