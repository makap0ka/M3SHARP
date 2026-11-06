using System.Data;
using System.Globalization;
using System.Text;

namespace m3sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("TASK 1");

            int[,] array = new int[5, 5];
            Random random = new Random();

            int min = 1000;
            int max = -1000;
            int minIndex = 0;
            int maxIndex = 0;

            Console.WriteLine("Array:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-1000, 1001);

                    Console.Write($"{array[i, j],5}");

                    int index = i * 5 + j;

                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndex = index;
                    }

                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex = index;
                    }
                }

                Console.WriteLine();
            }

            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);

            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int index = i * 5 + j;

                    if (index > start && index < end)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine($"Minimum element: {min}");
            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Sum between min and max: {sum}");

            // Task 2
            Console.WriteLine("\nTASK 2");

            int[] numbers = { 10, 5, 8, 3, 13, 7, 3, 9, 15 };

            Console.WriteLine("Array:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            int minimum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] - minimum == 5)
                {
                    count++;
                }
            }

            Console.WriteLine($"Minimum element: {minimum}");
            Console.WriteLine($"Number of elements different from minimum by 5: {count}");

        }
    }
}