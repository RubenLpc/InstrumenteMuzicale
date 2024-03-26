using System;
using System.IO;
using InstrumenteMuzicale;

namespace InstrumenteMuzicale
{
    class Program
    {
        static void Main()
        {
            string folderProiect = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string folderInstrumente = Path.Combine(folderProiect, "InstrumenteMuzicale");
            string numeFisierInstrumente = "instrumente.txt";
            string caleCompletaFisier = Path.Combine(folderInstrumente, numeFisierInstrumente);

            AdministrareInstrumente_FisierText adminInstrumente = new AdministrareInstrumente_FisierText(caleCompletaFisier);
            InstrumentMuzical instrumentNou = new InstrumentMuzical();
            int nrInstrumente = 0;

            string optiune;
            do
            {
                Console.WriteLine("C. Citire informatii instrument muzical de la tastatura");
                Console.WriteLine("I. Afisarea informațiilor despre ultimul instrument muzical introdus");
                Console.WriteLine("A. Afisare instrumente muzicale");
                Console.WriteLine("S. Salvare instrument muzical");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o opțiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        instrumentNou = CitireInstrumentTastatura();
                        
                        break;
                    case "I":
                        AfisareInstrument(instrumentNou);
                        break;
                    case "A":
                        InstrumentMuzical[] instrumente = adminInstrumente.GetInstrumente(out nrInstrumente);
                        AfisareInstrumente(instrumente);
                        break;
                    case "S":
                        adminInstrumente.AddInstrument(instrumentNou);
                        adminInstrumente.SalvareInstrumente();
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Opțiune inexistentă");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static InstrumentMuzical CitireInstrumentTastatura()
        {
            Console.WriteLine("Introduceti numele instrumentului muzical");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti tipul instrumentului muzical");
            string tip = Console.ReadLine();

            Console.WriteLine("Introduceti pretul instrumentului muzical");
            decimal pret;
            while (!decimal.TryParse(Console.ReadLine(), out pret))
            {
                Console.WriteLine("Introduceti un pret valid (numar decimal).");
            }

            InstrumentMuzical instrument = new InstrumentMuzical(0, nume, tip, pret);

            return instrument;
        }

        public static void AfisareInstrument(InstrumentMuzical instrument)
        {
            string infoInstrument = string.Format("Instrumentul cu id-ul #{0} are numele: {1}, tipul: {2} si pretul: {3}",
                    instrument.IdInstrument,
                    instrument.Nume ?? " NECUNOSCUT ",
                    instrument.Tip ?? " NECUNOSCUT ",
                    instrument.Pret);

            Console.WriteLine(infoInstrument);
        }

        public static void AfisareInstrumente(InstrumentMuzical[] instrumente)
        {
            Console.WriteLine("Instrumentele sunt:");
            foreach (InstrumentMuzical instrument in instrumente)
            {
                if (instrument != null)
                {
                    string infoInstrument = instrument.Info();
                    Console.WriteLine(infoInstrument);
                }
            }
        }
    }
}
