// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class ConversionHexa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez un entier à convertir en hexadécimal :");
        int entier = int.Parse(Console.ReadLine());

        string hexValue = ConvertirEnHexadecimal(entier);
        Console.WriteLine($"La valeur hexadécimale de {entier} est : {hexValue}");
    }

    static string ConvertirEnHexadecimal(int nombre)
    {
        // Implémentation ici
        return "";
    }
}

