// Задача 
// Дан двумерный массив
// Найти найти нечетные элементы, на четных местах после этого найти их сумму


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

void  Checkelements (int[,] matrix)
{
    Console.Write("нечетные элементы, на четных местах: ");
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            
            if((i%2==0)&&(j%2==0)) 
            {
                if(matrix[i,j]%2 !=0)
                {  
                    Console.Write($"{matrix[i,j]} ");
                                      
                }          
            }
        }
    }
}

void Sumelements(int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            
            if((i%2==0)&&(j%2==0)) 
            {
                if(matrix[i,j]%2 !=0)
                {
                    sum += matrix[i,j];                   
                }                
            }
        }
    }
//    return sum;
    Console.Write("сумма нечетных элементов, на четных местах: " + sum);
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
Checkelements (array);
Console.WriteLine();
Sumelements(array);
// PrintArray(array);

