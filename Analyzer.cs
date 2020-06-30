using System;
using System.Collections.Generic;
using System.Text;

namespace CountLetters
{
    class Analyzer
    {
        private char[] EuABC = new char[26];
        private char[] RuABC = new char[33];
        private char[] ExstraSym = new char[1]; // цифры, символы, пробелы и тд
        private Dictionary<char, int> RuSymbols = new Dictionary<char, int>();
        private Dictionary<char, int> EuSymbols = new Dictionary<char, int>();
        private Dictionary<char, int> ExstraSymbols = new Dictionary<char, int>(); // цифры, символы, пробелы и тд
        public string Str
        {
            get
            {
                return Str;
            }
            set
            {
                Str = value.ToUpper();
            }
        }

        public Analyzer()
        {
            string strRuABC = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string strEuABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] RuABC = strRuABC.ToCharArray();
            char[] EuABC = strEuABC.ToCharArray();

            CounterEveryRuSymbol();
            CounterEveryEuSymbol();
        }

        private void CounterEveryRuSymbol()
        {
            foreach (char symbol in RuABC)
            {
                int count = 0;
                for (int i = 0; i < Str.Length; i++)
                {
                    if (symbol == Str[i])
                    {
                        count++;
                    }
                }
                RuSymbols.Add(symbol, count);
            }
        }

        private void CounterEveryEuSymbol()
        {
            foreach (char symbol in EuABC)
            {
                int count = 0;
                for (int i = 0; i < Str.Length; i++)
                {
                    if (symbol == Str[i])
                    {
                        count++;
                    }
                }
                EuSymbols.Add(symbol, count);
            }
        }

        private int EuCounter
        {
            get
            {
                return EuCounter;
            }
            set
            {
                foreach (char symbol in EuSymbols.Keys)
                {
                    EuCounter += EuSymbols[symbol];
                }
            }
        }

        private int RuCounter
        {
            get
            {
                return RuCounter;
            }
            set
            {
                foreach (char symbol in RuSymbols.Keys)
                {
                    RuCounter += RuSymbols[symbol];
                }
            }
        }

        public void DisplayCountersRuABC()
        {
            foreach (char symbol in RuSymbols.Keys)
            {
                Console.WriteLine("{0} - {1}\t", symbol.ToString(), RuSymbols[symbol].ToString());
            }
        }

        public void DisplayCountersEuABC()
        {
            foreach (char symbol in EuSymbols.Keys)
            {
                Console.WriteLine("{0} - {1}\t", symbol.ToString(), EuSymbols[symbol].ToString());
            }
        }

        public void DisplayProbabilityRuABC()
        {
            double probably;
            foreach (char symbol in RuSymbols.Keys)
            {
                probably = RuSymbols[symbol] * 100 / Str.Length;
                Console.WriteLine("Вероятность {0} равна: {1}%", symbol.ToString(), probably.ToString());
            }
        }

        public void DisplayProbabilityEuABC()
        {
            double probably;
            foreach (char symbol in EuSymbols.Keys)
            {
                probably = EuSymbols[symbol] * 100 / Str.Length;
                Console.WriteLine("Вероятность {0} равна: {1}%", symbol.ToString(), probably.ToString());
            }
        }
    }
}
