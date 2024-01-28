
//1.3 Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
int[] array = { 1, 2, 5, 7, 8 }; // исходный массив

Console.Write($" Начальный массив: ");
foreach (int e in array)
{
    Console.Write($"{e} ");
}
for(int j = 0; j < array.Length / 2; j++)
{
    int temp = array[j];
    array[j] = array[array.Length - 1 - j];
    array[array.Length - 1 - j] = temp;
    }
Console.WriteLine();
Console.Write("Перевернутый массив: ");
foreach (int number in array)
{
    Console.Write($"{number} ");
}