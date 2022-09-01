
class Program{
static void Main(string[] args)
{
    var result = GetFirstReOccuredString("ABCA");
}

public static string GetFirstReOccuredString(string text)
{
    Dictionary<char,int> dict = new Dictionary<char,int>();

    for (int i = 0; i < text.Length-1; i++)
    {
        if(dict[text[i]] > 1)
          return text[i].ToString();
        else
           dict.Add(text[i],1);
    }
    return "null";
}
}