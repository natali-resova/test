/*
// Создать двумерный массив с размерами 3х5, состоящий из целых чисел

int[,] matrix = new int[3, 5];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/
/*
//Создание массива в виде функции
int[,] CreateMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
// Вывод на экран
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);
*/
/*
int[,] table1 = new int[2, 4] {
    {1, 1, 1, 1}
    {2, 2, 2, 2}
    };

int[,] table2 = new int[,] {
    {1, 1, 1, 1}
    {2, 2, 2, 2}
    };
    */

int[,] CreateMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix(7, 4); //вход
foreach (int e in matrix)
{
    if (IsInteresting(e) = true)
    {
        Console.Write(e);
    }
}
bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigit % 2 == 0)
    { 
        return true;
    }    
    return false;
}

int GetSumOfDigits(value)
{
    int sum = 0;
    while(value > 0)
    { 
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}