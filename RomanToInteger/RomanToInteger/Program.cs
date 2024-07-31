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

        public static int RomanToInteger(string input)
        {
            int number = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 < input.Length && romanDictionary[input[i]] < romanDictionary[input[i + 1]])
                {
                    number -= romanDictionary[input[i]];
                }
                else
                {
                    number += romanDictionary[input[i]];
                }
            }
            return number;
        }

        public static void PrintSample()
        {
            Console.WriteLine("MCMXCIV -> " + RomanToInteger("MCMXCIV"));
            Console.WriteLine("MMI -> " + RomanToInteger("MMI"));
        }

        static void Main(string[] args)
        {
            PrintSample();
        }
    }
}
