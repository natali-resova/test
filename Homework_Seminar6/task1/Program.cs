//1.Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
string GetStringFromArray(char[,] chars)
{
    string str = "";
    foreach (char c in chars)
    {
        str += c;
    }
    return str;
}

char[,] chars = {
    {'v', 'K', '?'},
    {'1', 'f', 'O'}
};
string str = GetStringFromArray(chars);
Console.WriteLine(str);