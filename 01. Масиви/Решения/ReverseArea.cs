namespace ReverseArea
{
    internal class Program
    {
        //задача 4. Обръщане на реда 
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Console.WriteLine("Enter values for elements:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Reversed element of area");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
