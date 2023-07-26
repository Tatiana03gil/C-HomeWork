/*Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.*/

/*double [,] CreateDouble2DArray (int rows, int columns, int minValue, int maxValue)
 {
    double[,] array = new double [rows, columns];
    for (int i = 0; i<rows;i++)
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().NextDouble() 
            + new Random().Next(minValue,maxValue); 
            array[i,j] = Math.Round(array[i,j],2);
        }
    return array;
}

void ShowDouble2DArray (double[,] array)
{
    for (int i = 0; i<array.GetLength(0);i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write (array[i,j] + "  ");
        Console.WriteLine ();
        }
}

Console.WriteLine ("Input number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input minimal value: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input maximal value: ");
int max = Convert.ToInt32 (Console.ReadLine());

double[,] myArray = CreateDouble2DArray (rows, columns, min, max);
ShowDouble2DArray (myArray);*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента 
 или же указание, что такого элемента нет.*/

/*int [,] Create2DArray (int rows, int columns, int minValue, int maxValue)
 {
    int[,] array = new int [rows, columns];
    for (int i = 0; i<rows;i++)
        for (int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue,maxValue+1); 
    return array;
}

string FindElement (int[,] array, int row, int column)
{
    string answer = string.Empty;
    if (row >= array.GetLength(0) || column >= array.GetLength(1)) 
        {
            Console.WriteLine ("Такого элемента нет!");
            return answer;
        }
    else 
        {
        Console.WriteLine ($"Элемент [{row}, {column}] равен {array[row,column]}");
        return answer = Convert.ToString (array[row,column]);
        }
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i<array.GetLength(0);i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write (array[i,j] + "  ");
            Console.WriteLine ();
        }
}

Console.WriteLine ("Input number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input minimal value: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input maximal value: ");
int max = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input index of row for search: ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input index of column for search: ");
int column = Convert.ToInt32 (Console.ReadLine());

int [,] newArray = Create2DArray(rows, columns, min, max);
Show2DArray (newArray);
string result = FindElement (newArray, row, column);*/

/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/

/*int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

double[] ColumnArithmeticMean(int[,] array)
{
    double[] arrayOfMeans = new double[array.GetLength(1)];
    double sumOfRowsInColumn = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            sumOfRowsInColumn += Convert.ToDouble(array[j, i]);
        arrayOfMeans[i] = sumOfRowsInColumn / array.GetLength(0);
        arrayOfMeans[i] = Math.Round(arrayOfMeans[i], 2);
        sumOfRowsInColumn = 0;
    }
    return arrayOfMeans;
}

void ShowDouble2DArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "    ");
        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, min, max);
Show2DArray(myArray);
double[] arithmeticMeans = ColumnArithmeticMean(myArray);
ShowDouble2DArray(arithmeticMeans);*/