using System;

namespace Solution1
{
    class Program
    {
        static int SumTwoFactor(int[] array, int desiredResult = 2020)
        {
            int sum = 0;
            int result = 0;
            bool sumFound = false;

            while (!sumFound)
            {
                for (int y = 0; y < array.Length && !sumFound; y++)
                {
                    for (int z = y; z < array.Length && !sumFound; z++)
                    {
                        sum = array[z] + array[y];
                        Console.WriteLine(sum);
                        if (sum == desiredResult)
                        {
                            sumFound = true;
                            result = array[y] * array[z];
                        }
                    }
                }
            }
            return result;
        }
        static int SumThreeFactor(int[] array, int desiredResult = 2020)
        {
            int sum = 0;
            int result = 0;
            bool sumFound = false;

            while (!sumFound)
            {
                for (int x = 0; x < array.Length && !sumFound; x++)
                {
                    for (int y = x; y < array.Length && !sumFound; y++)
                    {
                        for (int z = y; z < array.Length && !sumFound; z++)
                        {
                            sum = array[x] + array[y] + array[z];
                            Console.WriteLine(sum);
                            if (sum == desiredResult)
                            {
                                sumFound = true;
                                result = array[x] * array[y] * array[z];
                            }
                        }
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ethan\Downloads\input.txt");
            int[] getalArray = new int[lines.Length];

            int x = 0;
            

            //converteer string naar int
            for (int i = 0; i < lines.Length; i++)
            {
                x = Convert.ToInt32(lines[i]);
                getalArray[i] = x;
            }

            //use this array to test the method
            int[] testArray = { 1721, 979, 366, 299, 675, 1456 };

            //SOLUTION PART 1
            //int answer = SumTwoFactor(convertedLines, 2020);
            //Console.WriteLine($"\nANSWER: {answer}");

            //SOLUTION PART 2
            int answer = SumThreeFactor(getalArray, 2020);
            Console.WriteLine($"\nANSWER: {answer}");
        }
    }
}
