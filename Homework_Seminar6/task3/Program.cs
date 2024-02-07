//3.Задайте произвольную строку. Выясните, является ли она палиндромом.

string s = "fregatagerf";

int IsPalindromeOrNo(string str)
//bool IsPalindromeOrNo(string str)
{
    
    int N = str.Length;    
    int i = 0;
    while (i < N / 2)
    { 
        if (str[i] == str[N - 1 - i])   
        {    
            i++;           
        }
        else
        {
             Console.Write("Строка - не палиндромом");                
            break;
        }
    }
    return i;
}


 int i = IsPalindromeOrNo(s);
 //bool res = IsPalindromeOrNo(s);
 if (i > 0)
 //if (res == true)
{
    Console.Write("Строка является палиндромом");
}
