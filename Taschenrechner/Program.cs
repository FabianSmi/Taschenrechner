using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Taschenrechner
{
    internal class Program
    {

        static int Rechnungstyp()
        {

            while (true)
            {
                Console.WriteLine("Gib eine Rechenmethode ein: ");

                string input = Console.ReadLine()!;

                string[] Rechenmethoden = ["Addition", "Subtraction", "Multiplication", "Division"];

                for (int i = 0; 0 < Rechenmethoden.Length; i++)
                {
                    if (input == Rechenmethoden[i])
                    {
                        return i;
                    }
                }
            }
        }

        static int RechnungsMethode(int rechnungsTyp)
        {
            string zahl1Eingabe;
            string zahl2Eingabe;

            int zahl1;
            int zahl2;

            int ergebnis;

            Console.WriteLine("Gib die erste Zahl ein:");
            zahl1Eingabe = Console.ReadLine()!;
            zahl1 = int.Parse(zahl1Eingabe);

            Console.WriteLine("Gib die zweite Zahl ein:");
            zahl2Eingabe = Console.ReadLine()!;
            zahl2 = int.Parse(zahl2Eingabe);

            while (true)
            {
                    if (rechnungsTyp == 0)
                    {
                        ergebnis = zahl1 + zahl2;
                        return ergebnis;
                    }
                    else if (rechnungsTyp == 1)
                    {
                        ergebnis = zahl1 - zahl2;
                        return ergebnis;
                    }
                    else if (rechnungsTyp == 2)
                    {
                        ergebnis = zahl1 * zahl2;
                        return ergebnis;
                    }
                    else if (rechnungsTyp == 3)
                    {
                        ergebnis = zahl1 / zahl2;
                        return ergebnis;
                    }
                
            }

        }
        static void Main(string[] args)
        {
            int selectedType = Rechnungstyp();
            int ergebnis = RechnungsMethode(selectedType);
            Console.WriteLine("Das Ergebnis lautet: " + ergebnis);

        }
    }
}
