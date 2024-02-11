//3251=>1+5+2+3
//BASE: if (nameof == 0)
//3251=>1+Sum(325) с помощью рекурсивного вызова уменьшаем сложность задачи
//Задача - сделать рекурсивный вызов от числа с меньшим кол-вом разрядов

int SumOfDigits( int num)
{
    Console.WriteLine($"Call:{num}");// отладка
    if (num < 10)
    //if (num == 0)
    {
        Console.WriteLine($"Hi, i am here");// базовый вызов
        //И только после того, как дошли до баз. вызова, начинается сложение(стр.17)
        //return 0;
        return num;
    }
    //int sum = num % 10 + SumOfDigits(num / 10);
    int sum = num % 10;
    int temp = SumOfDigits(num / 10);
    Console.WriteLine($"Go back:{num / 10},{temp}");
    sum += temp;
    return sum; 
}





int res = SumOfDigits( 345);
Console.WriteLine(res);