using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier
{
    class Client
    {
        private string nom,prenom,adresse;

        //Constructeur
        public Client(string nom, string prenom, string adresse) {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }

        //Affichage des informations du client
        public void afficher() {
            Console.WriteLine("Nom : "+this.nom);
            Console.WriteLine("Prenom : "+this.prenom);
            Console.WriteLine("Adresse : "+this.adresse);
        }

    }
}
