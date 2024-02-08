using System;

class OttoniumSpiel
{
    private const int REIHEN = 5;
    private const int SPALTEN = 5;
    private int[,] spielfeld = new int[REIHEN, SPALTEN];

    public OttoniumSpiel()
    {
        // gibt ein Spielfeld mit einem Zufälligem LED aus
        Random rand = new Random();
        for (int i = 0; i < REIHEN; i++)
        {
            for (int j = 0; j < SPALTEN; j++)
            {
                spielfeld[i, j] = rand.Next(2); // 0 für aus, 1 für an
            }
        }
    }

    public void KnopfDrücken(int zeile, int spalte)
    {
        // Umschalten des gedrückten Knopfes und seiner Nachbarn
        Umschalten(zeile, spalte);
        Umschalten(zeile - 1, spalte); // überprüfe oben
        Umschalten(zeile + 1, spalte); // überprüfe unten
        Umschalten(zeile, spalte - 1); // überprüfe links
        Umschalten(zeile, spalte + 1); // überprüfe rechts
    }

    private void Umschalten(int zeile, int spalte)
    {
        if (zeile >= 0 && zeile < REIHEN && spalte >= 0 && spalte < SPALTEN)
        {
            spielfeld[zeile, spalte] = 1 - spielfeld[zeile, spalte]; // Schalte das Licht um (0 wird zu 1 und umgekehrt)
        }
    }

    public bool IstGelöst()
    {
        // Überprüfe, ob alle Lichter ausgeschaltet sind
        for (int i = 0; i < REIHEN; i++)
        {
            for (int j = 0; j < SPALTEN; j++)
            {
                if (spielfeld[i, j] == 1)
                {
                    return false; // Es gibt noch ein eingeschaltetes Licht
                }
            }
        }
        return true; // Alle Lichter sind ausgeschaltet
    }

    public void SpielfeldAnzeigen()
    {
        // Ausgabe des aktuellen Spielfelds
        for (int i = 0; i < REIHEN; i++)
        {
            for (int j = 0; j < SPALTEN; j++)
            {
                if (spielfeld[i, j] == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Setzt die Farbe auf Rot für die LEDS die an sind
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue; // Setzt die Farbe auf Weiß für die LEDS die aus sind
                }
                Console.Write("O "); // O für eingeschaltetes Licht
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White; // Setzt die Farbe wieder auf Weiß
    }
}



