/* Написать программу, которая принимает два числа и проверяет, является ли первое число
квадратом второго.
пример a = 25, b = 5 -> да
пример b = 2, b = 10 -> нет */

Console.WriteLine("Введите первое число:");
string firstnumber = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string secondnumber = Console.ReadLine();

int firstnum = int.Parse(firstnumber); 
int secondnum = int.Parse(secondnumber); 

if (secondnum * secondnum == firstnum)
    {
        Console.WriteLine($"a = {firstnumber}, b= {secondnumber} -> да");
    }
else
 {
        Console.WriteLine($"a = {firstnumber}, b = {secondnumber} -> нет");
    }

