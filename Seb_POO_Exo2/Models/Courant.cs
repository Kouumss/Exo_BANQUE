using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Seb_POO_Exo2.Models
{
    public class Courant
    {
        private decimal _ligneDeCredit;
        public string Numero { get; set; }
        public decimal Solde { get; set; }
        public decimal LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }
            set
            {
                if (value < 0)
                    return;
                _ligneDeCredit = value;
            }
        }
        public Personne? Titulaire { get; set; }


        public void Retrait(decimal montant)
        {
            if (montant < 0)
                return;
            if (Solde - montant < -LigneDeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                Console.WriteLine();
                return;
            }

            Solde -= montant;
            Console.WriteLine("Transaction ok.");
            Console.WriteLine();
        }

        public void Depot(decimal montant)
        {
            if (montant < 0)
                return;
            Solde += montant;
        }

        public void Details()
        {
            Console.WriteLine($" Numéro de compte : {Numero}");
            Console.WriteLine($" Titulaire : {Titulaire.Nom + " " + Titulaire.Prenom}");
            Console.WriteLine($" Solde : {Solde}");
            Console.WriteLine($" Limite : {LigneDeCredit}");
            Console.WriteLine();
        }

        public static decimal operator + (decimal solde, Courant courant)
        {
          return solde + courant.Solde < 0 ? 0 : courant.Solde;
        }
    }


}
