using System;

namespace BetterDesign
{
    public class Processor
    {
        IReader reader;
        IParser parser;
        IWriter writer;

        public Processor(
            IReader specificReader,
            IParser specificParser,
            IWriter specificWriter)
        {
            reader = specificReader;
            parser = specificParser;
            writer = specificWriter;
        }

        public void process()
        {
            Console.WriteLine("Processor.process()");

            reader.read();
            parser.parse();
            writer.save();
        }
    }
}
