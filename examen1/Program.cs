using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 12345;
        int resultado = MoverNumeroDelMedioAlPrincipio(numero);
        Console.WriteLine(resultado);
    }

    static int MoverNumeroDelMedioAlPrincipio(int numero)
    {
        string numeroString = numero.ToString();
        int longitud = numeroString.Length;
        int mitad = longitud / 2;
        
        char numeroDelMedio = (longitud % 2 == 0) ? numeroString[mitad - 1] : numeroString[mitad];
        
        string restoNumero = numeroString.Remove(mitad, 1);
        string numeroMovidoString = numeroDelMedio + restoNumero;
        
        return int.Parse(numeroMovidoString);
    }
}