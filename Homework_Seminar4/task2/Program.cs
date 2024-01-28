//2.Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//2.1 Функция формирвания массива случайными трехзначными цифрами

int[] CreateArrayRandom(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

//int[] array = CreateArrayRandom(10);
//PrintArray(array);



//2.2 Функция определения кол-ва четных чисел в массиве
int GetEvenQuantity(int[] arr)
{
    int countEven = 0; //счетчик целых чисел
    foreach (int elem in arr)
    {
        if (elem % 2 == 0)
        {
            countEven = countEven + 1;
        }
    }
    return countEven;
}

//2.3 Вывод массива на экран

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = CreateArrayRandom(20);
PrintArray(array);
int count = GetEvenQuantity(array);
Console.WriteLine($"- there are {count} even numbers");