using System;
using System.Collections.Generic;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Abcde abcdertwet wfsdf";
            Analyzer analyzer = new Analyzer(text);
            analyzer.DisplayCountersEuABC(1);
        }
    }
}
