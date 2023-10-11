class Program
{
    static void Main()
    {
        Console.WriteLine("Verificador de maiúsculas");
        string text = Console.ReadLine();
        int length = text.Length;
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int cont = 0;

        
        for (int i = 0; i < length; i++) // Posição da letra do text
        {
            for (int j = 0; j < alfabeto.Length; j++) // Posição das letras do alfabeto
            {
                // Se text posição i bater com alguma letra maiúscula do alfabeto
                // Incrementa o cont
                if (text[i] == alfabeto[j])
                {
                    cont++;
                    Console.WriteLine(alfabeto[j]);
                }

            }
        }

        for (int i = 0; i < text.Length; i++)
        {
            // Se (não) text na posição i for uma letra
            // Decrementa o length
            if (!char.IsLetter(text[i]))
            {
                length--;
            }
        }

        Console.WriteLine(cont);
        Console.WriteLine(length);


        bool resul = false;
        if (cont != length)
        {
            resul = resul;
        }
        else
        {
            resul = true;   
        }

        Console.WriteLine($"O resultado é: {resul}");
    }
}