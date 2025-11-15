## Списък List<T> е динамична структура от данни, подобна на масив,
 но може да променя размера си автоматично – добавя, премахва и вмъква елементи.

	<T> означава тип на елементите – int, string, double, bool, char, object

Пример:
	List<int> numbers = new List<int>();

## Основни характеристики
- Елементите са подредени и достъпни чрез индекс.
- Позволява динамично добавяне/премахване на елементи.
- Част е от пространството имена:  using System.Collections.Generic;

## Създаване на списък
	List<int> nums = new List<int>();
	List<string> names = new List<string>() { "Ivan", "Maria" };

## Основни операции
➤ Добавяне
	nums.Add(10);
	nums.AddRange(new int[] { 1, 2, 3 });

➤ Достъп чрез индекс
	int x = nums[0];
	nums[1] = 50;

➤ Размер на списъка
	int count = nums.Count;

➤ Премахване
	nums.Remove(10);       // премахва първото срещане на 10
	nums.RemoveAt(2);      // премахва елемент на позиция 2
	nums.Clear();          // изчиства списъка

➤ Търсене
	bool found = nums.Contains(5);
	int index = nums.IndexOf(5);    // -1 ако липсва

## Обхождане на списък
➤ чрез for оператор:

	for (int i = 0; i < nums.Count; i++)
    		Console.WriteLine(nums[i]);

➤ чрез foreach:

	foreach (int n in nums)
    		Console.WriteLine(n);

## Вмъкване на елемент

	nums.Insert(1, 99);   // на индекс 1 вмъква 99

## Полезни методи
Метод		Описание
Add()		Добавя елемент
AddRange()	Добавя няколко елемента
Insert()	Вмъква на определен индекс
Remove()	Премахва по стойност
RemoveAt()	Премахва по индекс
Contains()	Проверява дали съществува елемент
IndexOf()	Връща индекса на елемент
Sort()		Подрежда елементите
Reverse()	Обръща реда