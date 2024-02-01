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
// Проверить, делится ли сумма цифр числа на 2
/*Этапы решения:
1 Заполнение массива CreatrTable
2 Проход по элементам массива
3 Взятие очередного элементам
4 Проверка элемена на "интересность": IsInteresting
      -вычисление суммы цифр числа SumOfDigits    
      -проверка суммы на четность IsEven
5 Вывод на экран "интересных" элементов (после проверки)
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

int[,] matrix = CreateMatrix(3, 4); //вход
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}