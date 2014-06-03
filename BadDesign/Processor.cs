using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadDesign
{
    public class Processor
    {
        Reader reader;
        XMLParser xmlParser;
        JsonParser jsonParser;
        Writer writer;

        public Processor()
        {
            reader = new Reader();
            xmlParser = new XMLParser();
            jsonParser = new JsonParser();
            writer = new Writer();
        }

        public void process(string docType)
        {
            Console.WriteLine("Processor.process()");

            reader.read();

            if (docType.StartsWith("XML"))
            {
                xmlParser.parse();
            }
            else if (docType.StartsWith("Json"))
            {
                jsonParser.parse();
            }
            else
            {
                Console.WriteLine("Invalid document type");
            }

            writer.save();
        }
    }
}
