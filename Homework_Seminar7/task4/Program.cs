//3.Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void PrintReverseArray(int[] array, int i = 0)
{
    if(i != array.Length)
     {
        PrintReverseArray(array, i + 1);
        Console.Write($"{array[i]} ");
    }
}       

   int[] array = {5, 70, 1, 0, 9, 999};
    PrintReverseArray(array);            
