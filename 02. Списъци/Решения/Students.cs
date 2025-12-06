namespace Students
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            List<double> Grades = new List<double>();
			
            Console.Write("Въведи брой ученици: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name;
                double grade;
                while (true)
                {
                    Console.Write("Ученик: ");
                    name = Console.ReadLine();
                    if (name.Length >= 2)
                    {
                        break;// Излиза от while при въвдени валидни данни
                    }
                    else
                    {
                        Console.WriteLine("Името трябва да е поне 2 символа.");
                        Console.WriteLine("Опитай отново: ");
                    }
                }

                Names.Add(name);

                while (true)
                {
                    Console.Write("Оценка: ");
                    if (double.TryParse(Console.ReadLine(), out grade) && grade >= 2 && grade <= 6)
                    {
                        break;// Излиза от while при въвдени валидни данни
                    }
                    else
                    {
                        Console.WriteLine("Оценката трябва да е число между 2 и 6.");
                        Console.WriteLine("Опитай отново: ");
                    }
                }

                Grades.Add(grade);

            }
            Console.WriteLine("-------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{Names[i]} - {Grades[i]}");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Избери индекс: ");

           int removeIndex;

                // повтаряме, докато не се въведе валидно число в диапазона
                while (true)
                {
                    string input = Console.ReadLine();

                    // опитваме да преобразуваме текста в число
                    if (int.TryParse(input, out removeIndex))
                    {
                        // проверяваме дали индексът е в диапазона 1..Names.Count
                        if (removeIndex >= 1 && removeIndex <= Names.Count)
                        {
                            break; // излизаме от цикъла, защото е валиден
                        }
                        else
                        {
                            Console.WriteLine($"Моля въведи число между 1 и {Names.Count}:");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Моля въведи валидно число:");
                    }
                }
			
            Names.RemoveAt(removeIndex - 1);
            Grades.RemoveAt(removeIndex - 1);

            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{Names[i]} - {Grades[i]}");
            }
        }
    }
}
