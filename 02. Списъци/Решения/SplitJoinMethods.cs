namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. задача
            // Прочитаме един ред текст от конзолата – очакваме числа, разделени с интервал.
            // Пример: "10 20 30 40"
            string values = Console.ReadLine();

            // Разделяме въведения текст по интервали и го превръщаме в списък от стрингове.
            // Пример: {"10", "20", "30", "40"}
            List<string> items = values.Split(' ').ToList();

            // Създаваме празен списък от цели числа.
            List<int> nums = new();

            // Обхождаме списъка items и всяко текстово число го преобразуваме до int.
            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));  // Добавяме към nums
            }

            // Печатаме резултата.
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }



            // ВТОРО РЕШЕНИЕ – същото, но по-кратко
            // Тук комбинираме Split + превръщане в числа + ToList в една верига (pipeline).
            List<int> numbers = values
                .Split(' ')         // правим масив от стрингове
                .Select(int.Parse)  // превръщаме всеки елемент в int
                .ToList();          // правим ги в List<int>

            // Отпечатване
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }



            // ТРЕТО РЕШЕНИЕ – всичко на един ред
            // Прочитаме нов ред от конзолата, разделяме по интервал,
            // превръщаме в числа и ги добавяме в списък.
            List<int> numsAllinOneLine =
                 Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();


            // Създаваме списък от string елементи.
            // В него има 5 думи: "one", "two", "three", "four", "five".
            List<string> list = new List<string>()
                      { "one", "two", "three", "four", "five"};

            // Обхождаме списъка с for цикъл.
            // list.Count дава броя на елементите.
            // list[i] достъпва елемент по индекс.
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }

            // -----------------------------------------------------------
            // Добавяне на елементи

            // Add() — добавя елемент в края на списъка.
            list.Add("six");   // списъкът става: one, two, three, four, five, six

            // Insert(index, value) — вмъква елемент на определена позиция.
            // Тук вмъкваме "zero" на индекс 0 -> става първият елемент.
            list.Insert(0, "zero");
            // списъкът става: zero, one, two, three, four, five, six

            // -----------------------------------------------------------
            // Премахване на елементи

            // Remove("value") — премахва първото срещане на дадена стойност.
            // Тук премахваме първото "two".
            list.Remove("two");
            // списъкът става: zero, one, three, four, five, six

            // RemoveAt(index) — премахва елемент по индекс.
            // Премахваме елемента на индекс 1 (това е "one").
            list.RemoveAt(1);
            // списъкът става: zero, three, four, five, six

            // -----------------------------------------------------------
            // Проверки

            // Contains("value") — проверява дали дадена стойност съществува.
            Console.WriteLine(list.Contains("four"));
            // извежда True ако "four" съществува

            // IndexOf("value") — връща индекса на първото срещане.
            // Ако няма такъв елемент -> връща -1.
            Console.WriteLine(list.IndexOf("four"));
            // например ще върне 2

            // -----------------------------------------------------------
            // Промяна на елемент

            // Намереният индекс на "four" се използва,
            // за да заменим стойността му с "one".
            list[list.IndexOf("four")] = "one";
            // списъкът става: zero, three, one, five, six

            // -----------------------------------------------------------
            // Принтиране на списъка

            Console.WriteLine("----------------------");

            // string.Join("; ", list) съединява всички елементи в един ред,
            // разделени със "; ".
            Console.WriteLine(string.Join("; ", list));




        }
    }
}
