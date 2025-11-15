namespace MaxMin
{
    internal class Program
    {
        //задача 2. Максимален и минимален елемент на масив
        static void Main(string[] args)
        {
            int[] num = { 2, 45, 67, 12, 67, -7 };

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > max) max = num[i];
                if (num[i] < min) min = num[i];
            }

            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }
    }
}
