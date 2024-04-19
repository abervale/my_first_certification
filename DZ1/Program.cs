// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



void PrintNaturalNumbers(int num1, int num2)
{
    if (num1 > 0 && num2 > 0)
    {
        if (num1 < num2)
        {
            if (num1 == num2) return;
            PrintNaturalNumbers(num1, num2 - 1);
        }

    if (num1 > num2)
    {
        if (num1 == num2) return;
        PrintNaturalNumbers(num1, num2 + 1);
    }
    Console.Write($"{num2} ");
    }
    else
    {
        Console.Write("НЕВЕРНЫЙ ВВОД ДАННЫХ");
    }
}


Console.WriteLine("ВВЕДИТЕ НАТУРАЛЬНОЕ ЧИСЛО M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ НАТУРАЛЬНОЕ ЧИСЛО N ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(M, N);