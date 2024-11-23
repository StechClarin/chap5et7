// See https://aka.ms/new-console-template for more information
using System;

class JeuNombre
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Choisissez un nombre entre 1 et 10 : ");
            int nombre = int.Parse(Console.ReadLine());

            if (nombre < 1 || nombre > 10)
            {
                throw new ArgumentException("Saisissez un nombre compris entre [1, 10].");
            }

            if (nombre == 5)
            {
                Console.WriteLine("Vous avez gagné !");
            }
            else
            {
                Console.WriteLine("Vous avez perdu.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
}
