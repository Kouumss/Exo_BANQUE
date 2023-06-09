﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using Seb_POO_Exo2.Models;

namespace Seb_POO_Exo2
{

    class Program
    {


        static void Main(string[] args)
        {
            DateTime date = new DateTime(1992, 06, 17);
            Personne personne = new()
            {
                Nom = "Jaffar",
                Prenom = "Messaoudi",
                DateNaiss = date,
            };

            Courant compte1 = new()
            {
                Numero = "123456789",
                LigneDeCredit = 1250,
                Solde = 5500,
                Titulaire = personne,

            };
            Courant compte2 = new()
            {
                Numero = "BE41033745540221",
                LigneDeCredit = 1250,
                Solde = 1500,
                Titulaire = personne,

            };
            Courant compte3 = new()
            {
                Numero = "BE18950153408865",
                LigneDeCredit = 1250,
                Solde = 3000,
                Titulaire = personne,

            };

            personne.Afficher();
            compte1.Details();
            compte1.Retrait(150);
            compte1.Details();
            compte1.Retrait(975);
            compte1.Details();
            compte1.Depot(3000);

            Banque maBanque = new()
            {
                nom = "Belfius",
            };

           
            maBanque.Ajouter(compte1);
            maBanque.Ajouter(compte2);
            maBanque.Ajouter(compte3);


            var num_compte = maBanque.Compte.Select(i => i.Key);

            Console.WriteLine($"Liste des comptes : " + string.Join(" ", num_compte));

            maBanque.Supprimer(compte1.Numero);

            Console.WriteLine($"Liste des comptes : " + string.Join(" ", num_compte));

           

            compte3.Details();
        }
    }




}