using System;

namespace BetterDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            IParser parser = new JsonParser(); //IParser parcer = new XMLParser();
            IWriter writer = new Writer();

            Processor p = new Processor(reader, parser, writer);
            p.process();

            Console.ReadKey(true);
        }
    }
}