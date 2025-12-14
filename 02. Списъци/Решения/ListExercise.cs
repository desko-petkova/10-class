using System.Threading.Channels;

namespace Task1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            // 1) Създаване на списък от думи
            Console.WriteLine("Enter words:");
            List<string> words = Console.ReadLine()
                .Split(' ')
                .ToList();

            // Count
            Console.WriteLine($"Count: {words.Count}");

            // 2) Нов списък за думи по-дълги от 3 символа и започващщи с главна буква
            List<string> filtered = new List<string>();

            foreach (string w in words)
            {
                bool longEnough = w.Length > 3;     //True при дума над 3 символа
                bool startsWithUpper = char.IsUpper(w[0]);   // True при главна първа буква на думата 

                if (longEnough && startsWithUpper )
                {
                    // проверка дали думата вече не съществува в списъка
                    if (!filtered.Contains(w))  // прилага се обратна логика чрез логическото отрицание (!)
                    {
                        filtered.Add(w);
                    }
                }
            }
            //Отпечатване на списъка filtered
            Console.WriteLine("Filtered:");
            Console.WriteLine(string.Join(", ", filtered));

            // 3) Обръщане на списъка filtered
            filtered.Reverse();
            Console.WriteLine("Filtered reversed:");
            Console.WriteLine(string.Join(", ", filtered));


            // 4) Проверка за наличие на дума
            string searchWord = Console.ReadLine();
            int index = words.IndexOf(searchWord);

            if (index != -1)
                Console.WriteLine($"\"{searchWord}\" found at index {index}");
            else
                Console.WriteLine($"\"{searchWord}\" not found.");

            // 5) Думи с четна дължина 
            List<string> repeatedEven = new List<string>();

            foreach (string w in words)
            {
                if (w.Length % 2 == 0)
                {
                    if (!repeatedEven.Contains(w))
                        repeatedEven.Add(w);
                }
            }

            // 6) Извеждане на елементите с четен брой букви
            Console.WriteLine("Repeated Even-Length Words:");
            Console.WriteLine(string.Join(", ", repeatedEven));

            // 7) Сложно сортиране — първо по дължина, после по азбучен ред
            for (int i = 0; i < words.Count - 1; i++)
            {
                for (int j = 0; j < words.Count - 1 - i; j++)
                {
                    bool needSwap = false;

                    // 1) По дължина
                    if (words[j].Length > words[j + 1].Length)
                    {
                        needSwap = true;
                    }
                    // 2) Ако дължините са равни - сортиране по азбучен ред
                    // Методът string.Compare(a, b) сравнява две думи по азбучен ред.
                    // Той връща:
                    //          отрицателно число → a е преди b(правилен ред)
                    //          0 → думите са еднакви
                    //          положително число → a е след b(грешен ред)
                    else if (words[j].Length == words[j + 1].Length)
                    {                     
                        if (string.Compare(words[j], words[j + 1]) > 0)
                        {
                            needSwap = true;
                        }
                    }

                    // Ако needSwap е true  - разменяме стойностите на двата елемента от списъка
                    if (needSwap)
                    {
                        string temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted list");
            Console.WriteLine(string.Join(", ", words));

        }
    }
}
