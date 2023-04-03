﻿using System;
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

        public static bool operator ==(Personne p1, Personne p2)
        {
            return p1.Nom == p2.Nom && p1.Prenom == p2.Prenom;
        }
        public static bool operator !=(Personne p1, Personne p2)
        {
            return !(p1 == p2);
        }
    }
}
