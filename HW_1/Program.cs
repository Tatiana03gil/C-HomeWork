/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.*/

/*Console.WriteLine ("Введите первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num1>num2) Console.WriteLine ("Из двух введенных чисел большее число " + num1);
else Console.WriteLine ("Из двух введенных чисел большее число " + num2);
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

/*Console.WriteLine ("Введите первое число:");
int number1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе число:");
int number2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите третье число:");
int number3 = Convert.ToInt32 (Console.ReadLine ());

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine ("Максимальное число из трех - это " + max);
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

/*Console.WriteLine ("Введите число:");
int number = Convert.ToInt32 (Console.ReadLine ());
if (number % 2 == 0) Console.WriteLine ("Это четное число");
else Console.WriteLine ("Это нечетное число");
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32 (Console.ReadLine ());
int chet = 2;
while (chet <= number) {
    Console.Write (chet + " ");
    chet = chet + 2;}