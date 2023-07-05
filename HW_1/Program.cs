/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.*/

/*Console.WriteLine ("Введите первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num1>num2) Console.WriteLine ("Из двух введенных чисел большее число " + num1);
else Console.WriteLine ("Из двух введенных чисел большее число " + num2);
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.WriteLine ("Введите первое число:");
int number1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе число:");
int number2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите третье число:");
int number3 = Convert.ToInt32 (Console.ReadLine ());

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine ("Максимальное число из трех - это " + max);