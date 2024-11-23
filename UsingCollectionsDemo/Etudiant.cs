using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsageCollections
{
    public class Étudiant
    {
        public string Nom { get; set; }
        public double NoteCC { get; set; } // Note de contrôle continu
        public double NoteDevoir { get; set; } // Note des devoirs

        // Calcul de la moyenne pondérée
        public double CalculerMoyenne()
        {
            return (NoteCC * 0.33) + (NoteDevoir * 0.67);
        }
    }
}
