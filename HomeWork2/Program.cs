using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class HomeWork2
{
    static void Main()
    {
        const int count = 1_000_000;
        const int searchIndex = 496752; // Индекс 496753-го элемента (с учетом индексации с 0)

        // Создаем 3 пустых коллекции
        List<int> list = new List<int>();
        ArrayList arrayList = new ArrayList();
        LinkedList<int> linkedList = new LinkedList<int>();

        // Создаем объект Random
        Random random = new Random();

        // Заполняем List
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < count; i++)
        {
            list.Add(random.Next());
        }
        stopwatch.Stop();
        Console.WriteLine($"Время заполнения List: {stopwatch.ElapsedMilliseconds} мс");

        // Заполняем ArrayList
        stopwatch.Restart();
        for (int i = 0; i < count; i++)
        {
            arrayList.Add(random.Next());
        }
        stopwatch.Stop();
        Console.WriteLine($"Время заполнения ArrayList: {stopwatch.ElapsedMilliseconds} мс");

        // Заполняем LinkedList
        stopwatch.Restart();
        for (int i = 0; i < count; i++)
        {
            linkedList.AddLast(random.Next());
        }
        stopwatch.Stop();
        Console.WriteLine($"Время заполнения LinkedList: {stopwatch.ElapsedMilliseconds} мс");

        // Ищем 496753-ый элемент в List
        stopwatch.Restart();
        int listElement = list[searchIndex];
        stopwatch.Stop();
        Console.WriteLine($"Время поиска 496753-го элемента в List: {stopwatch.ElapsedMilliseconds} мс");

        // Ищем 496753-ый элемент в ArrayList
        stopwatch.Restart();
        int arrayListElement = (int)arrayList[searchIndex];
        stopwatch.Stop();
        Console.WriteLine($"Время поиска 496753-го элемента в ArrayList: {stopwatch.ElapsedMilliseconds} мс");

        // Ищем 496753-ый элемент в LinkedList
        stopwatch.Restart();
        int linkedListElement = linkedList.ElementAt(searchIndex);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска 496753-го элемента в LinkedList: {stopwatch.ElapsedMilliseconds} мс");

        // Вывод элементов из коллекции, делящихся на 3 без остатка, из List
        stopwatch.Restart();
        foreach (int item in list)
        {
            if (item % 3 == 0)
            {
                // Console.WriteLine(item); // Раскомментируйте, если нужно вывести все элементы
            }
        }
        stopwatch.Stop();
        Console.WriteLine($"Время вывода элементов, делящихся на 3, из List: {stopwatch.ElapsedMilliseconds} мс");

        // Вывод элементов из коллекции, делящихся на 3 без остатка, из ArrayList
        stopwatch.Restart();
        foreach (int item in arrayList)
        {
            if (item % 3 == 0)
            {
                // Console.WriteLine(item); // Раскомментируйте, если нужно вывести все элементы
            }
        }
        stopwatch.Stop();
        Console.WriteLine($"Время вывода элементов, делящихся на 3, из ArrayList: {stopwatch.ElapsedMilliseconds} мс");

        // Вывод элементов из коллекции, делящихся на 3 без остатка, из LinkedList
        stopwatch.Restart();
        foreach (int item in linkedList)
        {
            if (item % 3 == 0)
            {
                // Console.WriteLine(item); // Раскомментируйте, если нужно вывести все элементы
            }
        }
        stopwatch.Stop();
        Console.WriteLine($"Время вывода элементов, делящихся на 3, из LinkedList: {stopwatch.ElapsedMilliseconds} мс");

        // Время выполнения задания
        Console.WriteLine($"Время выполнения задания: {stopwatch.ElapsedMilliseconds} мс");
    }
}