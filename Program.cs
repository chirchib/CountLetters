using System;
using System.Collections.Generic;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Analyzer analyzer = new Analyzer(Console.ReadLine());
            analyzer.DisplayCountersRuABC();
        }
    }
}
