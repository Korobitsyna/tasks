/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница */

Console.WriteLine("Введите число от 1 до 7: ");
string number = Console.ReadLine();
int num = int.Parse(number); 

if (num == 1)
    {
        Console.WriteLine($"{num} -> Понедельник");
    }
else if (num == 2)
    {
        Console.WriteLine($"{num} -> Вторник");
    }
    else if (num == 3)
    {
        Console.WriteLine($"{num} -> Среда");
    }
    else if (num == 4)
    {
        Console.WriteLine($"{num} -> Четверг");
    }
    else if (num == 5)
    {
        Console.WriteLine($"{num} -> Пятница");
    }
    else if (num == 6)
    {
        Console.WriteLine($"{num} -> Суббота");
    }
    else if (num == 7)
    {
        Console.WriteLine($"{num} -> Воскресенье");
    }
    else
    {
        Console.WriteLine($"{num} -> Вы ввели неверное число");
    }