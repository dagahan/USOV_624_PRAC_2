using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите строку драгоценностей J: ");
        String J = Console.ReadLine();

        Console.WriteLine("Введите строку камней Ѕ: ");
        String S = Console.ReadLine();

        int count = 0;

        foreach (char stone in S)
        {
            if (J.Contains(stone))
            {
                count++;
            }

        }
        Console.WriteLine("Количество символов из S, которые являютсяя драгоценностями: " + count);
    }
}