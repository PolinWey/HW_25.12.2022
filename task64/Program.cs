/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Write("Введите число: ");
int N=int.Parse(Console.ReadLine()!);

string EvenNumbers(int start, int end)
{
    while (start % 2 != 0)
    {
        start--;
    }
    if (end == start)
    {
        return end.ToString();
    }
    return (start + " " + EvenNumbers(start - 2, end));
}

Console.WriteLine(EvenNumbers(N, 0));