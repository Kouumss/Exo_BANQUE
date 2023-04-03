using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seb_POO_Exo2.Models
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }
        public Personne()
        {

        }
        

        public void Afficher()
        {
            Console.WriteLine($"Nom : {Nom}, Prenom : {Prenom}");
            Console.WriteLine($"Prenom : {Prenom}");
            Console.WriteLine($"Date de naissance : {DateNaiss}");
            Console.WriteLine();
        }
    }
}
