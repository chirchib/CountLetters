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

        // возвращает строку но номеру буквы в алфавите  
        public string DisplayCountersRuABC(int index)
        {
            return RuABC[index].ToString() + " - " + RuSymbols[RuABC[index]].ToString();
        }

        // возвращает по ключу строку в виде  symbol.ToString() + " - " + EuSymbols[symbol].ToString()
        public string DisplayCountersEuABC(int index)
        {
            return EuABC[index].ToString() + " - " + EuSymbols[EuABC[index]].ToString();
        }

        // возвращает по ключу строку в виду
        public string DisplayProbabilityRuABC(int index)
        {
            double probably = RuSymbols[RuABC[index]] * 100 / Str.Length;
            return "Вероятность" + RuABC[index] + "равна: " + probably.ToString() + "%";
        }

        // выводит анг буквы с их вероятностью в строке
        public string DisplayProbabilityEuABC(int index)
        {
            double probably = EuSymbols[EuABC[index]] * 100 / Str.Length;
            return "Вероятность" + EuABC[index] + "равна: " + probably.ToString() + "%";
        }
    }
}
