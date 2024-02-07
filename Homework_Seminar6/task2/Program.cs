//2.Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string RowFromLovercase(string str)
{
   
    //foreach (char c in str.ToLower())
   // {
        
       // str += c;
    //}
    str = str.ToLower();
    return str;
}
string str = "HeLlO my DIA";
string s = RowFromLovercase(str);
Console.WriteLine(s);

/*
// Задача 3.Сколько введенных с консоли букв - гласные

int GetVovelsCount(string str)
{
    string vovels = "aoyuie";
    int counter = 0;
   // foreach (char c in str)
    foreach (char c in str.ToLower())// приводит все буквы к строчному виду
    // str.ToUpper() - приводит все буквы к заглавному виду
    
    {
      // if (vovels.Contains(c)) //если находим с в строке vovels = "aoyuie" - то true
      //  {
      //       counter++;
      //  }
       foreach (char vovel in vovels)
       {
        Console.WriteLine(c);//проверка
        if (c == vovel)
        {
            counter++;
        }
       }
    }
    return counter;
}
string str = Console.ReadLine()!;
int countVovels = GetVovelsCount(str);
Console.WriteLine(countVovels);
/*
string s = "hello";
 
        s = s.ToUpper();
 
        Console.WriteLine(s);        // ПРИВЕТ
        */