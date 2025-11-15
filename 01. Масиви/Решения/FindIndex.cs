using System;

namespace FindIndex
{
    internal class Program
    {
        //задача 7. Намиране индекса на първото срещане на число x
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter search value: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    Console.WriteLine($"Тhe position of the element with value {x} is at index {i}");
                    break;// Прекратява изпълнението на цикъла преждевременно
                }
            }

        }
    }
}
