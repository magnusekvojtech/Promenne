using System;

namespace Proměnné
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, jsem tvůj  papoušek");
            Console.WriteLine("Napiš co mám zvopakovat");
            string k_opakovani = Console.ReadLine();
            string zopakovano;
            zopakovano = k_opakovani + "," + k_opakovani + "!";
            Console.WriteLine(zopakovano);
            Console.ReadKey();

        }
    }
}
