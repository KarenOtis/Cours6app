using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours6app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est ton nom?");
            String nom = Console.ReadLine();
            Console.WriteLine("bonjour,{0}!", nom);

            Console.WriteLine("entrez un nombre");
            int nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un autre nombre");
            int nbr2 = int.Parse(Console.ReadLine());
            int somme = nb1 / nbr2;
            Console.WriteLine("la ration de {0} et {1} est {2}.", nb1, nbr2, somme);
        }
    }
}
