/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива*/

/*int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i<array.GetLength(0);i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write (array[i,j] + "  ");
            Console.WriteLine ();
        }
    Console.WriteLine();
}

void FromMaxToMinInRow(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = array.GetLength(1) - 1; count > 1; count--)
        {
            for (int j = 0; j < count; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
        }
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

int[,] newArray = Create2DArray(rows, columns, min, max);
Show2DArray (newArray);
FromMaxToMinInRow (newArray);
Show2DArray (newArray);
*/

/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку
 с наименьшей суммой элементов.*/

/*int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumRow(int[,] array)
{
    int row = 1;
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        minSum += array[0, j];
    int sum = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            row = i + 1;
        }
        sum = 0;
    }
    return row;
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2DArray(rows, columns, min, max);
Show2DArray(newArray);
int result = MinSumRow(newArray);
Console.WriteLine("Минимальная сумма находится в " + result + " строке");*/

/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.*/

/*int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < result.GetLength(0); i++)
            for (int j = 0; j < result.GetLength(1); j++)
                for (int m = 0; m < matrix1.GetLength(1); m++)
                    result[i, j] += matrix1[i, m] * matrix2[m, j];

    }
    else Console.WriteLine("Операция невозможна!");
    return result;
}

Console.WriteLine("Input number of rows (1st matrix): ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns (1st matrix): ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of rows (2nd matrix): ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns (2nd matrix): ");
int c2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateMatrix(r1, c1, min, max);
int[,] matrix2 = CreateMatrix(r2, c2, min, max);
ShowMatrix(matrix1);
ShowMatrix(matrix2);
int[,] result = MatrixMultiplication(matrix1, matrix2);
ShowMatrix(result);*/

/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно
выводить массив, добавляя индексы каждого элемента.*/

/*int[,,] Create3DArray10to99(int length, int width, int height)
{
    int[,,] array = new int[length, width, height];
    if (length * width * height <= 90)
    {
        int step = 90 / (length * width * height);
        int temp = 10 - step;
        for (int i = 0; i < length; i++)
            for (int j = 0; j < width; j++)
                for (int m = 0; m < height; m++)
                {
                    array[i, j, m] = temp + step;
                    temp += step;
                }
        return array;
    }
    else
    {
        Console.WriteLine("Impossible!");
        int[,,] noArray = new int[1, 1, 1];
        return noArray;
    }
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
                Console.Write($"{array[i, j, m]} ({i},{j},{m})   ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

Console.WriteLine("Input length of array: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input width of array: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input height of array: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = Create3DArray10to99(x, y, z);
Show3DArray(myArray);*/

/*Задача 62. Напишите программу, которая заполнит спирально массив a на b.*/

int[,] Spiral(int rows, int columns)
{
    int temp = 1;
    int[,] array = new int[rows, columns];
    for (int jNew = 0, iNew = 0; iNew <= rows; jNew++, iNew++)
    {
        for (int j = jNew, i = iNew; j < columns - jNew; j++)
            if (array[i, j] == 0) array[i, j] = temp++;
        for (int i = iNew, j = columns - 1 - jNew; i < rows - iNew; i++)
            if (array[i, j] == 0) array[i, j] = temp++;
        for (int j = columns - 1 - jNew, i = rows - 1 - iNew; j >= jNew; j--)
            if (array[i, j] == 0) array[i, j] = temp++;
        for (int i = rows - 1 - iNew, j = jNew; i >= iNew; i--)
            if (array[i, j] == 0) array[i, j] = temp++;
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = Spiral(rows, columns);
Show2DArray(array);