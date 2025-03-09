using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace Komposition_Schiff;

internal class Program
{
    static void Main(string[] args)
    {
        Schiff schiff = new Schiff();

        
            Console.WriteLine($"Willkommen zur Färe");

            Console.ReadKey();

            Console.WriteLine($"Füllen sie bitte die Anmeldung");

            while (true)
            {
                Console.WriteLine($"Wählen sie eine Option ");

                Console.WriteLine($"(1) Auto Einfügen    ");
                Console.WriteLine($"(2) Liste anzeigen   ");
                Console.WriteLine($"(3) Auto Entfernen   ");
                Console.WriteLine($"(4) Umsatz           ");
                Console.WriteLine($"(5) Exit           > ");
                
                int op = Int32.Parse(Console.ReadLine());

                if (op == 5)
                {
                    Console.WriteLine($"Auf Wiedersehen!!");
                    break;
                }

                switch (op)
                {
                    case 1:
                        schiff.AutoEinfügen();
                        Console.WriteLine($"Auto wurde hinzugefügt");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        schiff.AutoListe();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 3:
                        schiff.AutoEntfernen();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 4:
                        schiff.Umsatz();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine($"Option Ungültig!!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

                Auto[] autos = new Auto[schiff.liste.Count];
                autos = schiff.liste.ToArray();

                foreach (var a in autos)
                {
                    a.Ausgabe();
                }
            }
        
    }
}

