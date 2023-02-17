﻿// задача 48 Задайте двумерный массив размера m на n
// каждый элемент в массиве находится по формуле Аmn = m+n 
// Выведите полученный массив на экран
//m = 3 , n = 4
//0,1,2,3
//1,2,3,4
//2,3,4,5

Console.Write("Введите колличество строк массива  ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество строк массива  ");
int columens = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columens);

int[,] GetArray(int m, int n)
{
    int[,] result = new int [m,n];
    for(int i = 0; i < m; i ++)
    {
        for(int j = 0; j < n; j ++)
        {
            result[i,j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);