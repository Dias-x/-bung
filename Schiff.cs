namespace Komposition_Schiff;

public class Schiff
{
    public List<Auto> liste = new List<Auto>();

    public Schiff()
    {
        AutoEinfügen();
    }

    public void AutoEinfügen()
    {
        Auto auto = new Auto();
        liste.Add(auto);
    }

    public void AutoEntfernen()
    {
        AutoListe();

        Console.WriteLine($"Auto Entfernen!!");
        Console.Write($"Kennzeichen: ");
        string wahl = Console.ReadLine();

        for (int i = 0; i < liste.Count; i++)
        {
            if (liste[i].Kennzeichen == wahl)
            {
                liste.RemoveAt(i);
                Console.WriteLine($"Auto Entfernen!!");
                Console.ReadKey();
                break;
            }
            else if (i == liste.Count - 1)
            {
                Console.WriteLine($"Auto nicht erkannt!"); 
            }
        }
    }

    public void AutoListe()
    {
        foreach (var  a in liste)
        {
            a.Ausgabe();
        }
    }

    public void Umsatz()
    {
        double umsatz = 0;

        foreach (var a in liste)
        {
            umsatz += (a.Länge * 22);
        }

        Console.WriteLine($"Autos: {liste.Count} und der Umsatz beträgt: {umsatz}CHF ");
        
    }
}