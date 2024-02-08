using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottonium_Spiel_Projektwoche
{
    class Programm
    {
        static void Main(string[] args)
        {
            OttoniumSpiel spiel = new OttoniumSpiel();

            Console.WriteLine("Wilkommen beim Ottonium spiel");
            Console.WriteLine("Zum drücken einer LED, geben sie die Spalte und Zeile als Nummer an (1-5).");
            Console.WriteLine("Das Ziel ist es, alle Lichter auszuschalten.");

            while (!spiel.IstGelöst())
            {
                Console.WriteLine("\nAktuelles Spielfeld:");
                spiel.SpielfeldAnzeigen();

                Console.Write("\nBitte geben Sie die Zeilennummer (Horizontale) der LED an : ");
                int zeile = int.Parse(Console.ReadLine());
                Console.Write("Bitte geben Sie die Spaltennummer (Vertikale) der LED an ");
                int spalte = int.Parse(Console.ReadLine());

                spiel.KnopfDrücken(zeile, spalte);
            }

            Console.WriteLine("\nHerzlichen Glückwunsch! Sie haben das Spiel gelöst!");
            Console.WriteLine("Eine Fanfare ertönt zur Feier Ihres Erfolgs!");

            
        }
    }
}
