using System;

class Program
{
    static void Main()
    {
        string texto = "Hola";
        try
        {
            MostrarVocales(texto);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void MostrarVocales(string texto)
    {
        Console.WriteLine("Las vocales en el texto son:");
        int conteoVocales = 0;
        foreach (char letra in texto)
        {
            if (EsVocal(letra))
            {
                Console.WriteLine(letra);
                conteoVocales++;
                if (conteoVocales > 3)
                {
                    throw new Exception("El texto contiene más de 3 vocales.");
                }
            }
        }
    }

    static bool EsVocal(char letra)
    {
        letra = Char.ToLower(letra);
        return letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u';
    }
}