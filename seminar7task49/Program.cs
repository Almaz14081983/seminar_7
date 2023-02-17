// Задача 49 . задайте двумерный массив. Найдите элементы
// у которых, оба индекса четные, и замените эти элементы на их 
// квадраты
// например
//1 4 7 2   1 4 7 2
//5 9 2 3   5 81 2 9
//8 4 2 4   8 4 2 4


Console.Write("Введите колличество строк массива  ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество столбцов массива  ");
int columens = int.Parse(Console.ReadLine()!);

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

int[,] NumbersSquar (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            if((i%2==0)&&(j%2==0)) 
            {
                matrix [i,j] = (matrix [i,j])*(matrix [i,j]);
            }
        }
    }
    return matrix;
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

int[,] array = GetArray( rows, columens, 1, 10);
PrintArray(array);
Console.WriteLine();
NumbersSquar (array);
PrintArray(array);