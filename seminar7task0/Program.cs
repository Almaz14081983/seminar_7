// Задача 46, Задайте двумерный массив размером m*n, 
// заполненный случайными числами.
// m= 3, n=4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1.

Console.Clear();
int[,] array = new int[3,4];
FillArray(array);
PrintArray(array);

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
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i ++)
    {
        for(int j = 0; j < matr.GetLength(1); j ++)
        {
            matr[i,j] = new Random().Next(-10,100);
        }
 // Console.WriteLine();
    }
}

