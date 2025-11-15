namespace Areas
{
    internal class Program
    {
        //задача 1. Сума на елемнтите
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
  
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
