/* начало комментария
double N = 01234567890;
// Определение значения b - кол-ва разрядов в числе N
int b = 0;
double A = N;
while ( N >=1)
{    
    b = b + 1;   
    N =  N / 10;
}
//Console.WriteLine(b);
while (b >= 1)
{
double B = Math.Floor(A / Math.Pow(10,b-1));
double lastB = B % 10;
b = b - 1;
Console.Write(lastB + ",");
}
конец комментария
*/

//1.Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
/*
int[] numbers = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
int minRange = 10;
int maxRange = 90;
int count = 0;

foreach (int elem in numbers)
{
    if (elem >= minRange && elem <= maxRange)
    {
//        count = count + 1;
          count += 1;
    }
}
Console.Write(count);
*/

//2. Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
/*
int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
int count = 0;
foreach (int elem in array)
{
    if (elem % 2 == 0)
    {
        count += 1;
    }
}
Console.Write(count);
*/

/*
//3.Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
double FindMin = array[0];
double FindMax = array[0];
for (int i = 0; i < array.Length; i++)
    if (array[i] < FindMin)
    {
        FindMin = array[i];
    }
//Console.Write(FindMin);   

for (int i = 0; i < array.Length; i++)
    if (array[i] > FindMax)
    {
        FindMax = array[i];
    }
//Console.Write(FindMax);
double diff = FindMax - FindMin;
Console.Write(diff);
*/



  