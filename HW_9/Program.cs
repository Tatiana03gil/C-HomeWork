/*Задача 64: Задайте значение N. Напишите программу,
 которая выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.*/

/*void ShowNumbersNto1(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNumbersNto1(num - 1);
}

Console.WriteLine("Input number:");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbersNto1 (number);*/

/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в 
промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*int SumFromMtoN(int m, int n)
{
    if (m == n) return m;
    else
    {
        if (m < n) return SumFromMtoN(m, n - 1) + n;
        if (m > n) return SumFromMtoN(m - 1, n) + m;
    }
    return 0;
}


Console.WriteLine("Input number M:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N:");
int numN = Convert.ToInt32(Console.ReadLine());
int result = SumFromMtoN (numM, numN);
Console.WriteLine ("Sum of the elements is " + result);*/

/*Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.*/

int Ackermann(int m, int n)
{
    if (n > 0 && m > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    else if (n == 0 && m > 0) return Ackermann(m - 1, 1);
    else if (m == 0) return n + 1;
    else return 0;
}

Console.WriteLine("Input number M:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N:");
int numN = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(numM, numN);
Console.WriteLine($"Ackermann function ({numM},{numN}) is {result}");

