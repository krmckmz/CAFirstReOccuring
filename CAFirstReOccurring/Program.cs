using System;
class Program{
static void Main(string[] args)
{
    var result = GetFirstReOccuredChar("BCABA");
    Console.WriteLine(result);
    Console.ReadLine();
}

public static string GetFirstReOccuredChar(string text)
{
    Dictionary<char,int> dict = new Dictionary<char,int>();

    for (int i = 0; i < text.Length; i++)
    {
        int charCount = default(int);
        dict.TryGetValue(text[i],out charCount);

        if(dict.ContainsKey(text[i]) && charCount >= 1)
          return text[i].ToString();
        else
           dict.Add(text[i],1);
    }
    return "null";
}
}