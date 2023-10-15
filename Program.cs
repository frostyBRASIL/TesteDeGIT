public class Kata
{
    public static string Shortcut(string input)
    {
    string vogais = "aeiou";
    string inp = "";
    
    for (int i = 0; i < input.Length; i++)
    {
        for (int j = 0; j < vogais.Length; j++)
        {
            if (input[i] != vogais[j])
            {
                inp += input[i];
            }
        }
    }
    
    return inp;
    }

    static void Main()
    {
        Console.WriteLine(Shortcut("codewars"));    
    }
}