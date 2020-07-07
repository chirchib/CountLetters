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
                ProbabilityRuSymblos.Add(symbol, 0);
            }
            foreach (char symbol in EuABC)
            {
                EuSymbols.Add(symbol, 0);
                ProbabilityEuSymblos.Add(symbol, 0);
            }
        }

        private Dictionary<char, int> RuSymbols = new Dictionary<char, int>();
        private Dictionary<char, int> EuSymbols = new Dictionary<char, int>();
        private Dictionary<char, int> ExstraSymbols = new Dictionary<char, int>(); // цифры, символы, пробелы и тд

        private Dictionary<char, double> ProbabilityRuSymblos = new Dictionary<char, double>();
        private Dictionary<char, double> ProbabilityEuSymblos = new Dictionary<char, double>();

        private string Str;

        public Analyzer(string str)
        {
            Str = str.ToUpper();
            this.InitABC();
            this.CounterEverySymbol();
            this.CounterProbability();
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

        // возвращает словарь с русскими символами
        //TODO remove phrase "Display" from functions names
        
        public Dictionary<char, int> DisplayRuDictionary()
        {
            return RuSymbols;
        }

        //TODO Preferably change functions to property
        // example: private Dictionary<char, int> EuSymbols {private set; public get}


        // возвращает словарь с англ символами
        public Dictionary<char, int> DisplayEuDictionary()
        {
            return EuSymbols;
        }

        private void CounterProbability()
        {
            for (int i = 0; i < Str.Length; i++)
            {
                if (1040 <= Convert.ToInt32(Str[i]) && Convert.ToInt32(Str[i]) <= 1071)
                {
                    ProbabilityRuSymblos[Str[i]] = RuSymbols[Str[i]] * 100 / RuCounter();
                }
                else if (65 <= Convert.ToInt32(Str[i]) && Convert.ToInt32(Str[i]) <= 90)
                {
                    ProbabilityEuSymblos[Str[i]] = EuSymbols[Str[i]] * 100 / EuCounter();
                }
            }
        }

        // возвращает словарь с ру символами
        //TODO fix return value DisplayProbabilityRuSymbols from int to double
        public Dictionary<char,double> DisplayProbabilityRuSymbols()
        {
            return ProbabilityRuSymblos;
        }

        // возвращает словарь с англ символами
        public Dictionary<char, double> DisplayProbabilityEuSymbols()
        {
            return ProbabilityEuSymblos;
        }
    }
}
