using System;
using System.Collections.Generic;

class JeuNombre
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez la borne minimale : ");
        int borneMin = int.Parse(Console.ReadLine());

        Console.WriteLine("Entrez la borne maximale : ");
        int borneMax = int.Parse(Console.ReadLine());

        if (borneMin >= borneMax)
        {
            Console.WriteLine("Les bornes sont incorrectes. Réessayez.");
            return;
        }

        Random rnd = new Random();
        int nombreCible = rnd.Next(borneMin, borneMax + 1);
        List<int> choixFaits = new List<int>();
        int tentatives = 0;

        Console.WriteLine($"Trouvez le nombre entre {borneMin} et {borneMax} : ");

        while (true)
        {
            try
            {
                int nombre = int.Parse(Console.ReadLine());
                tentatives++;

                if (nombre < borneMin || nombre > borneMax)
                {
                    throw new ArgumentException($"Saisissez un nombre compris entre {borneMin} et {borneMax}.");
                }

                choixFaits.Add(nombre);

                if (nombre == nombreCible)
                {
                    Console.WriteLine("Félicitations ! Vous avez trouvé le nombre.");
                    double note = (double)(borneMax - borneMin + 1) / tentatives;
                    Console.WriteLine($"Votre note est : {note:F2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect. Réessayez !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}
