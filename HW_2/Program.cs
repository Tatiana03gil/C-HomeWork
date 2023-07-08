/*Задача 10: Напишите программу, которая принимает
на вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.*/

int Dozen (int number){
    int Dozens = number % 100 / 10;
    return Dozens;
        }

Console.WriteLine ("Введите трехзначное число: ");
int num = Convert.ToInt32 (Console.ReadLine ());
int Dec = Dozen (num);
Console.WriteLine ("Вторая цифра числа: " + Dec);

