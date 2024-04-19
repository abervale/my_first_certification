// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// пример: m = 2, n = 3 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int AckermannFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return AckermannFunction(n - 1, 1);
    }
    return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}

Console.WriteLine("ВВЕДИТЕ НАТУРАЛЬНОЕ ЧИСЛО n ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ НАТУРАЛЬНОЕ ЧИСЛО m ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(num1, num2);
Console.WriteLine(result);
