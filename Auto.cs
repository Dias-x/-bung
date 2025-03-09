namespace Komposition_Schiff;

public class Auto
{
    
        public string Name { get; set; }
        public string Model { get; set; }
        public double Länge { get; set; }
        public string Kennzeichen { get; set; }

        public Auto()
        {
            Eingabe();
        }

        public void Eingabe()
        {
            try
            {
                Console.WriteLine($"Autodaten eingeben ");
                Console.Write($"Besitzer Name: ");
                Name = Console.ReadLine();
                Console.Write($"Auto Model: ");
                Model = Console.ReadLine();
                Console.Write($"Länge des Autos: ");
                Länge = double.Parse(Console.ReadLine());
                Console.Write($"Kennzeichen: ");
                Kennzeichen = Console.ReadLine();

                Console.WriteLine($"--------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Ausgabe()
        {
            Console.WriteLine($"Name        : {Name}");
            Console.WriteLine($"Model       : {Model}");
            Console.WriteLine($"Länge       : {Länge}");
            Console.WriteLine($"Kennzeichen : {Kennzeichen}");

            Console.WriteLine($"-------------------------------");
        }
}
