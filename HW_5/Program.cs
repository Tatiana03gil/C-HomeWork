/*Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет
количество чётных чисел в массиве.*/

/*int[] CreateArrayThreeDigits (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + "  ");
    Console.WriteLine ();
}

int CountOfEvens (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0) count++;
    return count;
}

Console.WriteLine("Задайте размер массива:");
int length = Convert.ToInt32 (Console.ReadLine());
int[] newArray = CreateArrayThreeDigits (length);
ShowArray (newArray);
int result = CountOfEvens (newArray);
Console.WriteLine ("Количество четных чисел в массиве равно " + result);*/

/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/

/*int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + "  ");
    Console.WriteLine ();
}

int SumOddIndex (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2) sum += array[i];
    return sum;
}

Console.WriteLine("Задайте размер массива:");
int length = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Минимально возможное значение элемента массива:");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Максимально возможное значение элемента массива:");
int max = Convert.ToInt32 (Console.ReadLine());

int[] newArray = CreateRandomArray (length, min, max);
ShowArray (newArray);
int result = SumOddIndex (newArray);
Console.WriteLine ("Сумма элементов на нечетных позициях равна " + result);*/

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

double[] DoubleArray (int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine ($"Введите {i+1}-й элемент массива:");
        array[i] = Convert.ToDouble (Console.ReadLine());
    }
    return array;
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + "  ");
    Console.WriteLine ();
}

double SubtractionMaxMin (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) min = array[i];
        else if (array[i]>max) max = array[i];
    }
    double substraction = max - min;
    return substraction;
}

Console.WriteLine("Задайте размер массива:");
int length = Convert.ToInt32 (Console.ReadLine());
double[] myArray = DoubleArray (length);
ShowArray (myArray);
double result = SubtractionMaxMin (myArray);
Console.WriteLine("Разница между мин. и макс. элементами массива равна " + result);
