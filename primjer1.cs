using System;

namespace nasljedivanje3
{
    class Vozilo // nadklasa (parent)
    {
        public string marka = "Fiat"; 

        public void trubi()
        {
            Console.WriteLine("Biii Biiiiip!");
        }
    }

    class Automobil : Vozilo // podklasa (child)
    {
        public string model = "Punto";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobil mojAuto = new Automobil();

            mojAuto.trubi();

            Console.WriteLine(mojAuto.marka + " " + mojAuto.model);
        }
    }
}
