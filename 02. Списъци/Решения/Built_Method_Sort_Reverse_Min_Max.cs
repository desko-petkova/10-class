namespace SortNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
           List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            // Вграден метод за сортиране по възходящ ред (от най-малко към най-голямо)
            nums.Sort();
            Console.WriteLine("Sorted: ");
            Console.WriteLine(string.Join(", ", nums));

            // Вграден метод, който обръща реда на елементите в списъка
            nums.Reverse();
            Console.WriteLine("Reversed: ");
            Console.WriteLine(string.Join(", ", nums));

            // Намираме минималната стойност в списъка чрез вградения метод Min()
            int min = nums.Min();
            // Намираме максималната стойност чрез вградения метод Max()
            int max = nums.Max();
            Console.WriteLine("Max and Min value:");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
        }
    }
}
