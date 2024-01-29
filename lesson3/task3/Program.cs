/*//Заменить четные элементы массива нулями

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
ZeroEvenElements(array);/* тип данных не указываем при вызове функции
PrintArray(array);
*/
/*
// Генерация случайных чисел
Random rnd = new Random();

int size = 1000;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(1, 10);
    i = i + 1;
}

i = 0;
while (i < size)
{
    Console.Write($"{arr_int[i]} ");
    i = i + 1;
}
*/
/*
//Введение данных с консоли

//Console.WriteLine("Введите целое число:");

//string input = Console.ReadLine();//считывание строки с консоли и сохранение в переменной input
//int value = Convert.ToInt32(input);// преобразование считанных данных из строкового типа string в целый int

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine("Введите элемент массива(целое число):");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i = i + 1;
}

i = 0;
while (i < size)
{
    Console.Write($"{arr_int[i]} ");
    i = i + 1;
}
*/

// Вывод 
void PrintArray(int[] arr);
{
    foreach(int e in arr)
    {
        Console.Write($"{e} ");
    }
}

void ShowMessage(string msg)
{
    Console.Write(msg);
}