using System;

namespace BetterDesign
{
    public class Writer : IWriter
    {
        public void save()
        {
            Console.WriteLine("Writer.save()");
        }
    }
}
