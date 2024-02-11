//2.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//A(m,n) = n+1, если m = 0
//= A(m-1,1), если n =0 
//= A(m-1,A(m,n-1)), если m>0, n > 0

int A(int m, int n)
{
    //if (m > 0 && n > 0)
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return A(m - 1, 1);
    }
    //int temp = A(m - 1, A(m, n - 1));
    //Console.WriteLine($"Возврат:A={temp}");
    return A(m - 1, A(m, n - 1));
}
Console.Write(A(3, 4));



