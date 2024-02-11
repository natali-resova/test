//1.Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


void GetNaturalNumbers(int M, int N)
{   
    Console.Write(" " + M );
    if (M < N) GetNaturalNumbers(M+1, N);
    //if (N == M) Console.Write($"Stop: {N}");    
}

GetNaturalNumbers(10, 15);





