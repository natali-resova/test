//1 Определиться с действием (выписать 3-5 штук)
//вывод числа
//2 Определить закономерности в изменениях в действиях
//3 Ввести доп. переменную (счетчик)    
//заменить то, что изменяется в действиях, на счетчик
//4 Дать счетчику правильное начальное значение и его изменение
//5 Сформировать условие для остановки

//int N = 3;
//int i = -N;
//while (i <= N)
//{
//    Console.WriteLine(i);
//    i = i + 1;
//}

//int n = 6;
//int e = 2;
//while (e <= n)
//{
//    Console.Write(e);
//    Console.Write(' ');
//    e = e + 2;
//}

//int a = 5;
//int b = 5;
//if (a > b)
//{
//    Console.WriteLine("первое число больше");
//}
//else
//{
//  if (a < b)
//  {
//      Console.WriteLine("второе число больше");
//  }
//   else
//   {
//    Console.WriteLine("числа равны");
//   }
//}

//int a = 7;
//int b = 9;
//int c = 9;
//int max = a;
//if (b >= max)
//{ 
//    max = b;
//}
//if (c >= max)
//{
//    max = c;
//}
// в тесте пишем return max
//Console.WriteLine(max);

//int a = 8;
//if (a % 2 != 0)
//{
//    Console.WriteLine("нечетное");
//}
//else
//{
//    Console.WriteLine("четное");
//}

//int n = 750;
//int firstDigit = n / 100;
//int lastDigit = n % 10;
//int answer = firstDigit * 10 + lastDigit;
//1.Вывод числа
//Console.WriteLine(answer);
//2.Вывод строки, собираем строку, выводим не число
//Console.WriteLine($"{firstDigit}{lastDigit}");

//int a = 9;
//int b = 24;
//int r = b % a;
//if (r == 0)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine($"второе число {b} кратно первому числу {a}");
//      Console.WriteLine("NO. R=" + r);
//}

//1. Проверить кратность числа D одновременно 2 заданным числам a и b
//int a = 7;
//int b = 23;
//int D = 21;
//int r1 = D % a;
//int r2 = D % b;
//if (r1 + r2 ==0)
//{
//    Console.WriteLine($"число {D} кратно числам {a} и {b} одновременно");
//}
//else
//{
//     Console.WriteLine($"число {D} не кратно числам {a} и {b} одновременно");
//}

//2. Определить номер координатной плоскости, которой принадлежит точка с координатами (x,y)
//double x = +3.3;
//double y = -6.8;
//if (x > 0)
//{
//   if (y > 0)
//    {
//       Console.WriteLine($"I");
//    }  
//   else
//   {   
//       Console.WriteLine($"IV");
//   }
//}
//if (x < 0)
// {
//if (y > 0)
//  {
//      Console.WriteLine($"II");
//   }
//  else
//   {   
//       Console.WriteLine($"III");
//   }
// }

//3.Показать наибольшую цифру целого числа, принадлежащего отрезку [10, 99]
//D=d1*10+d2
//int D = 11;
//int d1 = D / 10;
//int d2 = D - d1*10;
//if (d1 > d2)
//{
//   Console.WriteLine(d1);
//}
//else
//{
//   if (d1 < d2)
//   {
//      Console.WriteLine(d2);
//   }
//   else
//   {
//       Console.WriteLine($"{d1}{d2} - количество десятков и единиц в этом числе одинаково");
//   }
//}

//4. Вывести цифры натурального числа N через запятую
long N = 19;
// Определение значения b - кол-ва разрядов в числе N

int b = 0;
long A = N;
int i = 0;
while ( N >=1)
{    
    b = b + 1;   
    N =  N / 10;
}
//Console.WriteLine(b);
while (i < b)
  { 
    long lastA = A % 10;
    A = A / 10;
    i = i + 1;
    Console.Write(lastA + ",");
  }





