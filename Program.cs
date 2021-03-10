using System;

namespace Atelier
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl= new Client("Alfaragui","Zakaria","Casablanca");
            //test.afficher();
            
            MAD dh = new MAD(2000);
            
            Compte C = new Compte(cl, dh);
            C.consulter(); //Consultation du compte test
            Console.WriteLine("\n");
            Console.WriteLine("Créditer le compte test de 2000 MAD.");
            C.Créditer(dh); //Créditer le compte test de 2000MAD
            C.consulter();
            Console.WriteLine("\n");
            Console.WriteLine("Débiter le compte test de 2000 MAD.");
            C.Débiter(dh); //Débiter le compte test de 2000MAD
            C.consulter();
            Console.WriteLine("\n");
            //Création d'un deuxième compte
            Client cl2 = new Client("Errouhi", "Mohammed", "Rabat");
            MAD dh2 = new MAD(500);
            Compte C2 = new Compte(cl2, dh2);
            C2.consulter();
            Console.WriteLine("\n");
            MAD dh3 = new MAD(700);
            //cl verse 500MAD a cl2
            Console.WriteLine("Cl verse la somme de 700MAD a Cl2");
            C.Verser(C2, dh3);
          
            C2.consulter();
            Console.WriteLine("\n");

            C.consulter();




        }
    }
}
