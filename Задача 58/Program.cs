// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using System;
using static System.Console;

Clear();
Write("Введите количество строк 1-й матрицы: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов 1-й матрицы (и строк 2-й матрицы): ");
int n = int.Parse(ReadLine());
Write("Введите количество столбцов 2-й матрицы: ");
int l = int.Parse(ReadLine());

int[,] firstMartrix = new int[m, n];
GetArray(firstMartrix);
WriteLine($"Первая матрица: ");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[n, l];
GetArray(secondMartrix);
WriteLine($"Вторая матрица: ");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[m,l];

MatrixMultiply(firstMartrix, secondMartrix, resultMatrix);
WriteLine($"Произведение первой и второй матриц: ");
PrintArray(resultMatrix);

void MatrixMultiply (int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int d = 0; d < firstMartrix.GetLength(1); d++)
      {
        sum += firstMartrix[i,d] * secondMartrix[d,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}