using System;
using OefeningenOOP;    //zo kan je jouw eigen namespace en ingesloten klassen gebruiken.

namespace Thema3_Klassen_en_Objecten_Oefeningen
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Maak de oefeningenreeks die bij deze opdracht is opgegeven.");
            Console.WriteLine("De opdrachten kan je downloaden via Teams of terugvinden in de git-repository.");
            Console.WriteLine("Zet de oefeningen in het bestand dat de namespace OefeningenOOP");
            Console.WriteLine("je kan deze namespace terugvinden in het bestand oefeningenOOP\n");

            Test t = new Test("mijnTestObject");
            Console.WriteLine(t.ToString());
        }
    }
}


