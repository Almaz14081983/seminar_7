//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите колличество строк массива  ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество столбцов массива  ");
int columens = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение в массиве ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение в массиве ");
int max = int.Parse(Console.ReadLine()!);

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

void ArithmMean(int[,] matrix)
{
 //   int sum = 0;
  //  int averageColumn = 0;
  //  int[,] result = new int [matrix.GetLength(0),matrix.GetLength(1)];
    int[] sum = new int [matrix.GetLength(1)];

    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {    
            Console.WriteLine(matrix[i,j]);      
            sum[i] = sum[i] + matrix[j,i];
                   
        }    
        Console.WriteLine();  
    }  
    Console.WriteLine();  
    foreach (double elem in sum)
    {
        Console.WriteLine(elem/matrix.GetLength(1)); 
    }
//    if((rows*columens)==count) Console.WriteLine("по индексу ["+ rowIndex +", " + columnIndex + "] нет элемента. " );
//    return sum;
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
ArithmMean(array);
