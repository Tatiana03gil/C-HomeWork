/*Задача 25: Напишите цикл, который принимает на
 вход два числа (A и B) и возводит число A в 
 натуральную степень B.*/

 int RaiseToPower (int number, int power)
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
Console. WriteLine ($"Число {a} в степени {b} равно {result}");
