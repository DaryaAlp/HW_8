// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;

WriteLine($"Введите размер массива X x Y x Z: ");
Write("Введите X: ");
int x = int.Parse(ReadLine());
Write("Введите Y: ");
int y = int.Parse(ReadLine());
Write("Введите Z: ");
int z = int.Parse(ReadLine());
WriteLine($" ");

int[,,] threearray = new int[x,y,z];
GetArray(threearray);
PrintArray(threearray);

void PrintArray (int[,,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int p = 0; p < z; p++)
            {
                Write($"{array[i,j,p]}({i} {j} {p})");
            }
            WriteLine();
        }
        WriteLine();
    }
}

void GetArray(int[,,] threearray)
{
  int[] temp = new int[threearray.GetLength(0) * threearray.GetLength(1) * threearray.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }

int count = 0; 
  for (int x = 0; x < threearray.GetLength(0); x++)
  {
    for (int y = 0; y < threearray.GetLength(1); y++)
    {
      for (int z = 0; z < threearray.GetLength(2); z++)
      {
        threearray[x, y, z] = temp[count];
        count++;
      }
    }
  }
}




