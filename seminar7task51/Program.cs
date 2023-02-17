// задача 51 задайте двумерный массив.
//Найдите сумму элементов,
//Находящейся на главной диагонали(с индексом (0,0) ; (1,1) ; (2,2).
//1 4 7 2
//5 9 2 3
//8 4 2 4 сумма элементов главной диагонали 1+9+2 = 12.

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

int DiagSum (int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {            
            if(i==j) 
            {
                sum = sum + (matrix [i,j]);
            }
        }
    }
    //Console.WriteLine("Сумма элементов главной диагоналиsum равно " + sum);
    return sum;
   
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
// NumbersSquar (array);
Console.WriteLine($"Сумма элементов главной диагонали равнa {DiagSum(array)}");