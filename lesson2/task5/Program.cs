//1. Проверка на аналичие в массиве числа 14
int[] array = { 1, 5, 34, 76, 43, 14, 67 };
int target = 14;

bool flag = false; //флаг опущен (выключен)

foreach (int elem in array)
{
    if (elem == target)
    {
        // Console.WriteLine("Yes");
        flag = true;
        //как понять, что мы ни разу здесь не были
    }
    //    else
    //    {
    //        Console.WriteLine("No");
    //    }
}
if (flag == true)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


//2. Изменить знак чисел на противоположный в массиве
int[] array = { 1, -2, 6, 5, -9 };

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
    Console.Write($"{array[i]}, ");
}