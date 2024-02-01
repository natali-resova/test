/*1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет:
  "Позиция по рядам выходит за пределы массива" или
"Позиция по колонкам выходит за пределы массива"
*/
int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};
int x = -2;
int y = 2;
//Console.WriteLine(numbers[1, 2]);

bool ValidatePozition(int[,] numbers)
{
    if (x - 1 < 0 || x - 1 > numbers.GetLength(0))
    {
        Console.WriteLine("Позиция по рядам выходит за пределы массива");

    }
    else
    {

        if (y - 1 < 0 || y - 1 > numbers.GetLength(1))
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
        }
        else
        {

            return true;

        }
    }
}
ValidatePozition(numbers);

/*
//int FindElementByPosition(int[,] array)
//{
int i = x - 1;
int j = y - 1;
int Elements = 0;
foreach (int e in numbers)

//for (int j = 0; j < numbers.GetLength(1); j++)
{
    if (ValidatePozition(numbers) == true)
    {
        Elements = numbers[i, j];
    }
}

/*
return numbers;
}
FindElementByPosition(array);*/
//Console.WriteLine(numbers[i, j]);*/
Console.WriteLine(Elements);