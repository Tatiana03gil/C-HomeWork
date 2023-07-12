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

/*Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.*/

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt ((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
    return distance;
}

Console.WriteLine (" Введите координаты первой точки (X1, Y1, Z1):");
int x1 = Convert.ToInt32 (Console.ReadLine ());
int y1 = Convert.ToInt32 (Console.ReadLine ());
int z1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine (" Введите координаты второй точки (X2, Y2, Z2):");
int x2 = Convert.ToInt32 (Console.ReadLine ());
int y2 = Convert.ToInt32 (Console.ReadLine ());
int z2 = Convert.ToInt32 (Console.ReadLine ());

double rasst = Distance (x1, y1, z1, x2, y2, z2);
Console.Write ("Расстояние: " + rasst);




