using System;
using System.Text;

namespace NumberToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new NumericLibrary();
            for (var i = 1; i < 100000000; i++)
            {
                Console.WriteLine("Number: {0} InWords: {1}", i, w.SpellNumber(i));
            }
        }
    }
}
