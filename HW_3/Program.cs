/*Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.*/

/*bool Palindrom (int num5){
int n1, n2, n3, n4;
n1 = num5 /10000;
n2 = num5 /1000 % 10;
n3 = num5 /10 % 10;
n4 = num5 % 10;
if (n1==n4 && n2==n3) return true;
else return false;}

Console.WriteLine ("Введите пятизначное число: ");
int num = Convert.ToInt32 (Console.ReadLine());
if (num > 99999) Console.WriteLine ("Wrong Input!");
else {
bool result = Palindrom (num);
Console.WriteLine (result);}*/

/* Решение задачи для любого по длине числа:

bool Palindrom (int number){
    int length = 0;
    int ost = number;
    while (ost >=1){
        ost = ost/10;
        length++;}

int first, last, delitel;
int result = -1;
while (length/2 > 0)
    {
        delitel = Convert.ToInt32(Math.Pow(10,length-1));
        first = number / delitel;
        last = number % 10;
        number = number % delitel / 10;
        if (first == last)
            {
                length = length - 2;
                result = 1;
            }
        else
            {
                length = 0;
                result = 0;
            }
    }
if (result > 0) return true;
else return false;
}

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine());
bool result = Palindrom (num);
Console.WriteLine (result);*/

