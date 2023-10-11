class Program
{
    static void Main()
    {
        Console.WriteLine("Verificador de maiúsculas");
        string text = Console.ReadLine();
        int length = text.Length;
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int cont = 0;

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (text[i] == alfabeto[j])
                {
                    cont++;
                    Console.WriteLine(alfabeto[j]);
                }

            }

            if (char.IsWhiteSpace(text[i]))
            {
                cont++;
            }

        }

        for (int i = 0; i < text.Length; i++)
        {
            if (!char.IsLetter(text[i]))
            {
                length--;
            }
        }

        Console.WriteLine(cont);
        Console.WriteLine(length);


        bool resul = false;
        if (cont != text.Length)
        {
            resul = resul;
        }
        else
        {
            resul = true;
        }

        Console.WriteLine($"O resultado é: {resul}")
    }
}