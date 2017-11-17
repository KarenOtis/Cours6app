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
            float nb1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un autre nombre");
            float nbr2 = float.Parse(Console.ReadLine());
            float ratio = nb1 / nbr2;
            Console.WriteLine("le ratio de {0} et {1} est {2}.", nb1, nbr2, ratio);
        }
    }
}
