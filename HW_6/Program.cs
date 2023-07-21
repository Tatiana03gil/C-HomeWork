/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

/*int CountPositive (int m)
{
    int count = 0;
    for (int i = 1; i <=m; i++)
    {
        Console.WriteLine ($"Введите {i}-e число:");
        int number = Convert.ToInt32 (Console.ReadLine());
        if (number > 0) count++;
    }
return count;
}

Console.WriteLine ("Сколько проверим чисел?");
int m = Convert.ToInt32 (Console.ReadLine());
int result = CountPositive (m);
Console.WriteLine ($"Вы ввели {result} положительных числа(ел)");*/

/*Задача 43: Напишите программу, которая найдёт точку
 пересечения двух прямых, заданных уравнениями 
 y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.*/

 void CrossPoint (double k1, double b1, double k2, double b2)
 {
    if (k1/k2==b1/b2) Console.WriteLine ("Прямые совпадают!");
    else if (k1==k2) Console.WriteLine ("Прямые параллельны!");
        else 
    {
    double x = (b2-b1) / (k1-k2);
    double y = k1*x+b1;
    Console.WriteLine ($"Прямые пересекаются в точке ({x}, {y})");
    }
 }

Console.Write ("Уравнение первой прямой y = k1 * x + b1 ");
Console.Write ("где k1 равно (введите) ");
int k1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("и b1 равно (введите) ");
int b1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Уравнение второй прямой y = k2 * x + b2 ");
Console.Write ("где k2 равно (введите) ");
int k2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("и b2 равно (введите) ");
int b2 = Convert.ToInt32 (Console.ReadLine());

CrossPoint (k1, b1, k2, b2);