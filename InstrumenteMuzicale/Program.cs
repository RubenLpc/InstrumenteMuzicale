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
            string numeFisierCumparari = "cumparari_instrumente.txt";
            string caleCompletaFisierInstrumente = Path.Combine(folderInstrumente, numeFisierInstrumente);
            string caleCompletaFisierCumparari = Path.Combine(folderInstrumente, numeFisierCumparari);

            AdministrareInstrumente_FisierText adminInstrumente = new AdministrareInstrumente_FisierText(caleCompletaFisierInstrumente);
            AdministrareCumparareInstrumente_FisierText adminCumparari = new AdministrareCumparareInstrumente_FisierText(caleCompletaFisierCumparari);
            InstrumentMuzical instrumentNou = new InstrumentMuzical();
            int nrInstrumente = 0;
            int nrCumparari = 0;

            string optiune;
            do
            {
                Console.WriteLine("C. Citire informatii instrument muzical de la tastatura");
                Console.WriteLine("I. Afisarea informațiilor despre ultimul instrument muzical introdus");
                Console.WriteLine("A. Afisare instrumente muzicale");
                Console.WriteLine("S. Salvare instrument muzical");
                Console.WriteLine("P. Adauga cumparare instrument");
                Console.WriteLine("F. Afisare cumparari instrumente");
                Console.WriteLine("G. Salvare cumparari instrumente");
                Console.WriteLine("N. Cautare instrument dupa nume");
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
                    case "P":
                        CumparareInstrumentMuzical cumparareNoua = CitireCumparareTastatura();
                        adminCumparari.AdaugaCumparare(cumparareNoua);
                        break;
                    case "F":
                        CumparareInstrumentMuzical[] cumparari = adminCumparari.GetCumparari(out nrCumparari);
                        AfisareCumparari(cumparari);
                        break;
                    case "G":
                        adminCumparari.SalvareCumparareInstrumente();
                        break;
                    case "N":
                        Console.WriteLine("Introduceti numele instrumentului de cautat:");
                        string numeInstrumentCautat = Console.ReadLine();
                        CautareInstrumentDupaNume(adminInstrumente, numeInstrumentCautat);
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

        public static CumparareInstrumentMuzical CitireCumparareTastatura()
        {
            Console.WriteLine("Introduceti numele clientului");
            string numeClient = Console.ReadLine();

            Console.WriteLine("Introduceti numele instrumentului");
            string numeInstrument = Console.ReadLine();

            Console.WriteLine("Introduceti tipul instrumentului");
            string tipInstrument = Console.ReadLine();

            Console.WriteLine("Introduceti pretul instrumentului");
            decimal pret;
            while (!decimal.TryParse(Console.ReadLine(), out pret))
            {
                Console.WriteLine("Introduceti un pret valid (numar decimal).");
            }

            Console.WriteLine("Introduceti data cumpararii (Format: dd.mm.yyyy)");
            DateTime dataCumparari;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out dataCumparari))
            {
                Console.WriteLine("Introduceti o data valida in formatul dd.mm.yyyy.");
            }

            CumparareInstrumentMuzical cumparare = new CumparareInstrumentMuzical(numeClient, numeInstrument, tipInstrument, pret, dataCumparari);

            return cumparare;
        }

        public static void AfisareCumparari(CumparareInstrumentMuzical[] cumparari)
        {
            Console.WriteLine("Cumpararile instrumentelor sunt:");
            foreach (CumparareInstrumentMuzical cumparare in cumparari)
            {
                if (cumparare != null)
                {
                    string infoCumparare = cumparare.Info();
                    Console.WriteLine(infoCumparare);
                }
            }
        }

        public static void CautareInstrumentDupaNume(AdministrareInstrumente_FisierText adminInstrumente, string numeInstrumentCautat)
        {
            InstrumentMuzical[] instrumente = adminInstrumente.GetInstrumente(out int nrInstrumente);
            bool instrumentGasit = false;

            foreach (InstrumentMuzical instrument in instrumente)
            {
                if (instrument != null && instrument.Nume.Equals(numeInstrumentCautat, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Instrumentul cu numele '{numeInstrumentCautat}' a fost gasit:");
                    AfisareInstrument(instrument);
                    instrumentGasit = true;
                }
            }

            if (!instrumentGasit)
            {
                Console.WriteLine($"Nu s-a gasit niciun instrument cu numele '{numeInstrumentCautat}'.");
            }
        }
    }
}

