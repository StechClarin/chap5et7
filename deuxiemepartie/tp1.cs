using System;
using System.Collections.Generic;

class ConversionHexa
{
    static void Main(string[] args)
    {
        List<string> historique = new List<string>(); // Liste pour stocker l'historique

        while (true)
        {
            Console.WriteLine("Entrez un entier à convertir en hexadécimal (ou 'q' pour quitter) :");
            string saisie = Console.ReadLine();

            if (saisie.ToLower() == "q") // Vérifier si l'utilisateur souhaite quitter
                break;

            try
            {
                int entier = int.Parse(saisie);

                // Conversion
                string hexValue = ConvertirEnHexadecimal(entier);

                // Afficher le résultat
                Console.WriteLine($"Valeur hexadécimale de {entier} : {hexValue}");

                // Ajouter à l'historique
                historique.Add($"{entier} -> {hexValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Veuillez entrer un entier valide.");
            }
        }

        // Afficher l'historique
        Console.WriteLine("\nHistorique des conversions :");
        foreach (string conversion in historique)
        {
            Console.WriteLine(conversion);
        }
    }

    static string ConvertirEnHexadecimal(int nombre)
    {
        if (nombre == 0)
            return "0";

        string hexadecimaux = "0123456789ABCDEF";
        List<char> result = new List<char>();

        while (nombre > 0)
        {
            int reste = nombre % 16;
            result.Add(hexadecimaux[reste]);
            nombre /= 16;
        }

        result.Reverse(); // Inverser l'ordre pour obtenir la bonne valeur
        return new string(result.ToArray());
    }
}
