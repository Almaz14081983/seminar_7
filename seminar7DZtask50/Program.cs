//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//[1,7] -> по такому индексу нет элемента.

Console.Clear();

Console.Write("Введите колличество строк массива  ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество столбцов массива  ");
int columens = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение в массиве ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение в массиве ");
int max = int.Parse(Console.ReadLine()!);

Console.Write("Введите индекс строки искомого элемента ");
int rowIndex = int.Parse(Console.ReadLine()!);

Console.Write("Введите индекс столбцa искомого элемента ");
int columnIndex = int.Parse(Console.ReadLine()!);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int [m,n];
    for(int i = 0; i < m; i ++)
    {
        for(int j = 0; j < n; j ++)
        {
            result[i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

void ElementPosition (int[,] matrix)
{
    int count = 0;
    int[,] result = new int [matrix.GetLength(0),matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {            
            if((i==rowIndex)&&(j==columnIndex))
            {
                Console.WriteLine("Значение искомого элемента в двумерном массиве = " + matrix[i,j]);
            }          
            if((i!=rowIndex)||(j!=columnIndex))
            {
                count = count + 1;
            }                      
        }      
    }    
    if((rows*columens)==count) Console.WriteLine("по индексу ["+ rowIndex +", " + columnIndex + "] нет элемента. " );
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

int[,] array = GetArray( rows, columens, min, max);
PrintArray(array);
ElementPosition(array);
