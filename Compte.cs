using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier
{
    class Compte
    {
        private readonly int NumCompte;
        private static int cpt = 0;
        private readonly Client titulaire;
        private MAD solde;
        private static MAD plafond = new MAD(2000);

        //Constructeur avec arguments
        public Compte(Client titulaire, MAD solde)
        {
            cpt++;
            this.NumCompte = cpt;
            this.solde = solde;
            this.titulaire = titulaire;

        }

        //Créditer un compte
        public bool Créditer(MAD somme)
        {
            MAD test = new MAD(0);
            if (somme > test)
            {
                this.solde += somme;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Débiter un compte
        public bool Débiter(MAD somme)
        {
            if (this.solde >= somme)
            {
                this.solde -= somme;
                return true;
            }
            else
            {
                return false;
            }

        }

        //Verser une somme d'un compte A a un compte B
        public bool Verser(Compte c, MAD somme)
        {
            if (Débiter(somme))
            {
                c.Créditer(somme);
                this.Débiter(somme);
                
                return true;
            }
            else
            {
                Console.WriteLine("Votre solde est insuffisant");
                return false;
            }
        }

        //Affichage des informations du compte
        public void consulter()
        {
            Console.WriteLine("Consultation du compte : ");
            this.titulaire.afficher();
            Console.WriteLine("Numero de compte : " + this.NumCompte);
            this.solde.afficher();
            
        }
    }
}
