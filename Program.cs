using System;
using System.Collections.Generic;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Analyzer analyzer = new Analyzer(Console.ReadLine());
            Dictionary<char, double> Ru = new Dictionary<char, double>();
            Ru = analyzer.DisplayProbabilityRuSymbols();
            foreach( char symbol in Ru.Keys)
            {
                Console.WriteLine("{0}  -  {1}%", symbol.ToString(), Ru[symbol].ToString());
            }
        }
    }
}
