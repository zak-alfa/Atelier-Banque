using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier
{
    class MAD
    {
        private double valeur;

        //Constructeur
        public MAD(double valeur){
            this.valeur = valeur;
        }

        //Operateur +
        public static MAD operator +(MAD v1,MAD v2)
        {
            MAD res = new MAD(0);
            res.valeur= v1.valeur + v2.valeur;
            return res;

        }

        //Operateur -
        public static MAD operator -(MAD v1, MAD v2)
        {
            MAD res = new MAD(0);
            res.valeur = v1.valeur - v2.valeur;
            return res;

        }

        //Operateur >
        public static bool operator >(MAD v1, MAD v2)
        {
            
            if (v1.valeur > v2.valeur)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Operateur <
        public static bool operator <(MAD v1, MAD v2)
        {

            if (v1.valeur < v2.valeur)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Operateur >=
        public static bool operator >=(MAD v1, MAD v2)
        {

            if (v1.valeur >= v2.valeur)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Operateur <=
        public static bool operator <=(MAD v1, MAD v2)
        {

            if (v1.valeur <= v2.valeur)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Affichage
        public void afficher()
        {
            Console.WriteLine("Solde : " + valeur+" MAD");
        }
     
    }
}
