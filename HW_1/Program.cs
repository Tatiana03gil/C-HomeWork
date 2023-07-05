/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.*/

Console.WriteLine ("Введите первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num1>num2) Console.WriteLine ("Из двух введенных чисел большее число " + num1);
else Console.WriteLine ("Из двух введенных чисел большее число " + num2);