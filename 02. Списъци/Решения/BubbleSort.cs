namespace BubbleSort
{
    //Алгоритъм за сортиране - метод на мехурчето
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < nums.Count-1; i++)
            {
                for (int j = 0; j < nums.Count - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
   
            Console.WriteLine(string.Join(", ", nums));

        }
    }
}
