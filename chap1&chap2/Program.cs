using System;
using System.Collections.Generic;

class JeuNombre
{
    static void Main(string[] args)
    {
        List<int> choixFaits = new List<int>();
        bool jeuEnCours = true;

        while (jeuEnCours)
        {
            try
            {
                Console.WriteLine("Choisissez un nombre entre 1 et 10 : ");
                int nombre = int.Parse(Console.ReadLine());

                if (nombre < 1 || nombre > 10)
                {
                    throw new ArgumentException("Saisissez un nombre compris entre [1, 10].");
                }

                choixFaits.Add(nombre);

                if (nombre == 5)
                {
                    Console.WriteLine("Vous avez gagné !");
                    jeuEnCours = false;
                }
                else
                {
                    Console.WriteLine("Vous avez perdu.");
                    Console.WriteLine($"Choix précédents : {string.Join(", ", choixFaits)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}
