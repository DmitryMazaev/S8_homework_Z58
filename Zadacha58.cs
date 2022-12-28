/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

//Задача на создание двух массивов, третий массив - сумма первы двух массивов

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк матрицы 1: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов матрицы 1: ");
int colums1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк матрицы 2: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов матрицы 2: ");
int colums2 = int.Parse(Console.ReadLine()!);

int[,] array1 = GetMatrix(rows1, colums1, 1, 10);
int[,] array2 = GetMatrix(rows2, colums2, 1, 10);

void ResultMatrix(int[,] array1, int[,] array2)
{
    if (colums1 == rows2)
    {
        int c = 0;
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                
                for (int t = 0; t < array1.GetLength(1); t++)
                {
                    c = c + array1[i,t]*array2[t,j];
                }          
                Console.Write($"{c} ");
                c = 0;
            }
            Console.WriteLine();
            
        }
    }
    else
    {
        Console.WriteLine("Матрицу 1 можно умножить на матрицу 2 только в том случае, если число столбцов матрицы 1 равно числу строк матрицы 2. Попробуйте еще раз.");
    }
}
Console.WriteLine($"Матрица 1 размером {rows1}x{colums1}:");
PrintMatrix(array1);
Console.WriteLine();
Console.WriteLine($"Матрица 2 размером {rows2}x{colums2}:");
PrintMatrix(array2);
Console.WriteLine();
Console.WriteLine($"Результирующая матрица размером {rows1}x{colums2}:");
ResultMatrix(array1, array2);
