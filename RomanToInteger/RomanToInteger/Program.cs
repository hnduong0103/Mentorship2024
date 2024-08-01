namespace RomanToInteger
{
    internal class Program
    {
        public static Dictionary<char, int> romanDictionary = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int RomanToInteger(string romanStr)
        {
            int number = 0;
            for (int i = 0; i < romanStr.Length; i++)
            {
                if (i + 1 >= romanStr.Length) //last digit of roman string
                {
                    number += romanDictionary[romanStr[i]];
                    continue;
                }

                if (romanDictionary[romanStr[i]] < romanDictionary[romanStr[i + 1]])
                {
                    number -= romanDictionary[romanStr[i]];
                }
                else
                {
                    number += romanDictionary[romanStr[i]];
                }
            }
            return number;
        }

        public static void PrintRomanToInteger(string romanStr)
        {
            Console.WriteLine($"{romanStr} -> {RomanToInteger(romanStr)}");
        }

        static void Main(string[] args)
        {
            PrintRomanToInteger("MMI");
            PrintRomanToInteger("MMXVI");
            PrintRomanToInteger("MCMXCIV");
        }
    }
}
