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

        // инициализация массивов с анг/рус буквами и инициализация ключей в словарях
        private void InitABC()
        {
            string strRuABC = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string strEuABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] RuABC = strRuABC.ToCharArray();
            char[] EuABC = strEuABC.ToCharArray();

            foreach (char symbol in RuABC)
            {
                RuSymbols.Add(symbol, 0);
            }
            foreach (char symbol in EuABC)
            {
                EuSymbols.Add(symbol, 0);
            }
        }

        private Dictionary<char, int> RuSymbols = new Dictionary<char, int>();
        private Dictionary<char, int> EuSymbols = new Dictionary<char, int>();
        private Dictionary<char, int> ExstraSymbols = new Dictionary<char, int>(); // цифры, символы, пробелы и тд
        private string Str;

        public Analyzer(string str)
        {
            Str = str.ToUpper();
            this.InitABC();
            this.CounterEverySymbol();
        }

        // Заполнение словарей
        private void CounterEverySymbol()
        {
            for (int i = 0; i < Str.Length; i++)
            {
                if (1040 <= Convert.ToInt32(Str[i]) && Convert.ToInt32(Str[i]) <= 1071)
                {
                    RuSymbols[Str[i]]++;
                }
                else if (65 <= Convert.ToInt32(Str[i]) && Convert.ToInt32(Str[i]) <= 90)
                {
                    EuSymbols[Str[i]]++;
                }
            }
        }       

        // возвращает количество английских букв
        public int EuCounter()
        {
            int EuCounter = 0;
            foreach (char symbol in EuSymbols.Keys)
            {
                EuCounter += EuSymbols[symbol];
            }
            return EuCounter;
        }

        // возвращает количество русских букв
        public int RuCounter()
        {
            int RuCounter = 0;
            foreach (char symbol in RuSymbols.Keys)
            {
                RuCounter += RuSymbols[symbol];
            }
            return RuCounter;
        }

        // выводит русские буквы и количество каждой в строке
        public void DisplayCountersRuABC()
        {
            foreach (char symbol in RuSymbols.Keys)
            {
                Console.WriteLine("{0} - {1}\t", symbol.ToString(), RuSymbols[symbol].ToString());
            }
        }

        // выводит английские буквы и кол-во каждой в строке
        public void DisplayCountersEuABC()
        {
            foreach (char symbol in EuSymbols.Keys)
            {
                Console.WriteLine("{0} - {1}\t", symbol.ToString(), EuSymbols[symbol].ToString());
            }
        }

        // выводит рус буквы с их вероятностью в строке
        public void DisplayProbabilityRuABC()
        {
            double probably;
            foreach (char symbol in RuSymbols.Keys)
            {
                probably = RuSymbols[symbol] * 100 / Str.Length;
                Console.WriteLine("Вероятность {0} равна: {1}%", symbol.ToString(), probably.ToString());
            }
        }

        // выводит анг буквы с их вероятностью в строке
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
