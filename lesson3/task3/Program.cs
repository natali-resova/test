//Заменить четные элементы массива нулями

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
//создаем целочисленный массив
int[] array = { 2, 10, 8, 7, 4, 5};
//запускаем функцию, в которую передадим наш массив
ZeroEvenElements(array);/* тип данных не указываем при вызове функции*/
PrintArray(array);
