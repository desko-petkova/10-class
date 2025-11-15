namespace CountX
{
    internal class Program
    {
        //задача 6. Брой на срещания на дадено число
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter search value: ");
            int x = int.Parse(Console.ReadLine());

            int count = 0;

            foreach(int element  in arr) 
            {
                if (element == x)
                    count++;
            }

            Console.WriteLine("Occurrences = " + count);
        }
    }
}
