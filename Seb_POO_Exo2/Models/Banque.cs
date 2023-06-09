﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seb_POO_Exo2.Models
{
    public class Banque
    {   
        public Banque()
        {

        }
        private Dictionary<string, Courant> _Compte;
        public Dictionary<string, Courant> Compte
        {
            get
            {
                return _Compte = _Compte ?? new Dictionary<string, Courant>();
            }
        }

        public string nom;

        public Courant this [string index]
        {
            get
            {
                Compte.TryGetValue(index, out Courant c);
                Compte.Add(index,c);
                Console.WriteLine(c);
                return c;
            }
            set
            {
                Compte[index] = value;
            }
        }

        public void Ajouter(Courant compte)
        {
            Compte.Add(compte.Numero, compte );
            Console.WriteLine("Compte ajouté !");
        }

        public void Supprimer(string numero)
        {   
            Compte.Remove(numero);
            Console.WriteLine("Compte supprimé !");
            Console.WriteLine();
        }

        public decimal AvoirDesCompte(Personne p)
        {
            decimal avoir = 0;

            foreach(KeyValuePair<string, Courant> kvp in Compte)
            {
                if(kvp.Value.Titulaire == p)
                {
                    avoir += kvp.Value;
                }
            }
            return avoir;
        }

      
       
    }
}