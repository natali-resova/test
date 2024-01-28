
//ДЗ Функции
//1. Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//1.1 Проверка суммы цифр числа

int SumDigitOfNumber(int n)
{
    int sum = 0;
    int i = 0;
    while (n > 0)
    {
        i = n % 10;
        sum = sum + i;
        n = n / 10;
    }
    //Console.WriteLine(sum);
    return sum;
}

// 1.2 Присвоение значения sum=false - если четная, sum=true - если нечетная

bool IsEven(int sum)
{
    if (sum % 2 == 0) return false;
    //     {
    //         return false;
    //    } 

    return true;
}
//int n = 1543219;
//int sum = SumDigitOfNumber(n);
//bool res = IsEven(sum);
//Console.Write(res);


while (true)
{
    Console.Write(" Введите целое число n или q для выхода:  ");
    //string input = Console.ReadLine();
    //if (input == "q") return;
    //else
    //{
        int n = Int32.Parse(Console.ReadLine()!);// || string input = Console.ReadLine();
        int sum = SumDigitOfNumber(n);
        bool res = IsEven(sum);
        if (res == false /*|| input = "q"*/ ) return;
    
}
//Console.Write("Stop");

