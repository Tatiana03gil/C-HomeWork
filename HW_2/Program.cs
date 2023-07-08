/*Задача 10: Напишите программу, которая принимает
на вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.*/

/*int Dozen (int number){
    int Dozens = number % 100 / 10;
    return Dozens;
        }

Console.WriteLine ("Введите трехзначное число: ");
int num = Convert.ToInt32 (Console.ReadLine ());
int Dec = Dozen (num);
Console.WriteLine ("Вторая цифра числа: " + Dec);
*/

/*Задача 13: Напишите программу, которая выводит
 третью цифру заданного числа.*/

 int Third (int number){
    if (number >=100){
        while (number >=1000) number = number / 10;
        int Thirds = number % 10;
        return Thirds;  
    }
    else return -1;
 }
    Console.WriteLine ("Введите число:");
    int num = Convert.ToInt32 (Console.ReadLine ());
    int num3 = Third (num);
    if (num3>-1) Console.WriteLine ("Третья цифра числа: " + num3);
    else Console.WriteLine ("У числа нет третьей цифры!");



