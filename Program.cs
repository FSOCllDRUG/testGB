/* Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых <=3 символа.
Первоначальный массив вводится с клавиатуры/задан в программе. 
!!!Не использовать списки!!!*/

string[] StringArray(string text)
{
string[] array = text.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
return array;
}
 
string[] Check(string[] strArr)
{
    string[] result=new string [1];
    int j=1;
    for (int i = 0; i < strArr.Length; i++) 
    {
        if (strArr[i].Length <= 3) 
        {
            if (result.Length < j) Array.Resize(ref result, result.Length + 1);
            result[j-1] = strArr[i];
            j++;
        }
    }
    return result;
}
 
void Print(string[] result)
{
    for(int i=0;i<result.Length;i++)
        System.Console.Write($"{result[i]} ");
}

System.Console.Write("Ввод значений через пробел: ");
string text= Console.ReadLine()!;
string[] strArr=StringArray(text);
string[] result=Check(strArr);
Console.Write("Значения из ввёденной строки, которые в длинну <=3 символа: ");
Print(result);