using System;
using OefeningenOOP;    //zo kan je jouw eigen namespace en ingesloten klassen gebruiken.

namespace Thema3_Klassen_en_Objecten_Oefeningen
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("THEMA3 - KLASSEN EN OBJECTEN - OEFENINGEN");
            Console.WriteLine("=========================================\n");
            Console.WriteLine(@"Maak de oefeningenreeks die bij deze opdracht is opgegeven (map ""solution items"").");
            Console.WriteLine(@"De bovenstaande lijn, en ook deze lijn, is trouwens een verbatim-string. Vandaar de @ voor de start-""");
            Console.WriteLine("De opdrachten kan je ook downloaden via de Teams-opdracht.");
            Console.WriteLine("\nZet de oefeningen in het bestand dat de namespace OefeningenOOP bevat");
            Console.WriteLine("je kan deze namespace toevoegen aan Program.cs met behulp van \"using\"");
            Console.WriteLine("De voorgaande lijn was trouwens niet verbatim. In die lijn is het escape-karakter \"\\\" gebruikt");
            Console.WriteLine("om rond het woord using dubbele \" te krijgen");


            Test t = new Test("mijnTestObject");
            Console.WriteLine($"\nEven testen of het aanmaken van een Test-object lukt...{t.ToString()}");
            Console.WriteLine("De bovenstaande string was trouwens een f-string. Die herken je aan het dollar teken voor de string");
        }
    }
}


