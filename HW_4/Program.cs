/*Задача 25: Напишите цикл, который принимает на
 вход два числа (A и B) и возводит число A в 
 натуральную степень B.*/

 /*int RaiseToPower (int number, int power)
 {
    int result = 1;
    for (int i = 1; i <= power; i++)
        result = result*number;
    return result;
 }

Console. WriteLine ("Введите число А: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console. WriteLine ("Введите число B: ");
int b = Convert.ToInt32 (Console.ReadLine());
int result = RaiseToPower (a, b);
Console. WriteLine ($"Число {a} в степени {b} равно {result}");*/

/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.*/

/*int Sum (int number)
{
int sum = 0;
for (; number >=1; number = number /10)
sum += number % 10;
return sum;
}

Console.WriteLine ("Введите число:");
int num = Convert.ToInt32 (Console.ReadLine());
int result = Sum (num);
Console.WriteLine ("Сумма цифр заданного числа равна " + result);*/

/*Задача 29: Напишите программу, которая задаёт массив 
из m элементов и выводит их на экран. 
Разработать метод CreateArray(int size), 
генерирующий массив на основе данных, вводимых пользователем.*/

/*int [] CreateArray (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine ($"Введите {i+1}-й элемент массива");
        array[i] = Convert.ToInt32 (Console.ReadLine());
    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + ";  ");
}

Console.WriteLine ("Задайте размер(m) массива: ");
int m = Convert.ToInt32 (Console.ReadLine());
int [] newArray = CreateArray (m);
ShowArray (newArray);
*/