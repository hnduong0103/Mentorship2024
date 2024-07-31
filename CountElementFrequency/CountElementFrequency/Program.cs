namespace CountElementFrequency
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Given: Array of Integer a
            // Want to get: The Most Frequent Value
            int[] a = new int[10];

            InitArr(a);
            BubbleSortAsc(a);
            GetAndPrintMostFrequent(a);
        }

        public static void BubbleSortAsc(int[] a)
        {
            int temp;
            for (int i = 0; i <= a.Length - 2; i++)
            {
                for (int j = i + 1; j <= a.Length - 1; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public static void GetAndPrintMostFrequent(int[] a)
        {
            int mostFrequentVal = a[0];
            int maxFrequency = 1;
            int currentVal = a[0];
            int currentFrequency = 1;

            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (a[i] == currentVal)
                {

                    // Count frequency
                    currentFrequency = currentFrequency + 1;
                }
                else
                {

                    // Everytime indexing to a new value, we got the frequency of the current value -> compare with the max to update
                    if (currentFrequency > maxFrequency)
                    {
                        maxFrequency = currentFrequency;
                        mostFrequentVal = currentVal;
                    }

                    // Renew the current value + frequency due to new value indexing changed
                    currentVal = a[i];
                    currentFrequency = 1;
                }
            }
            // Cover edge case: the last element of the array is the most frequent value
            if (currentFrequency > maxFrequency)
            {
                maxFrequency = currentFrequency;
                mostFrequentVal = currentVal;
            }
            Console.WriteLine("Max frequency: " + maxFrequency);
            Console.WriteLine("Most frequent value: " + mostFrequentVal);
        }

        public static void InitArr(int[] a)
        {
            a[0] = 12;
            a[1] = 23;
            a[2] = 23;
            a[3] = 1;
            a[4] = 12;
            a[5] = 23;
            a[6] = 3;
            a[7] = 4;
            a[8] = 1;
            a[9] = 23;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("a[" + i + "] = " + a[i]);
            }
        }
    }
}
