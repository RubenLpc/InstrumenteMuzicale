using System;
using System.Configuration;
using System.IO;
using System.Linq;
using InstrumenteMuzicale;
using LibrarieModele;
using NivelStocareDate;

namespace InstrumenteMuzicale
{
    class Program
    {
        static void Main()
        {
         



            //AdministrareStudenti_Memorie adminStudenti = new AdministrareStudenti_Memorie();
            string numeFisierInstrumente = ConfigurationManager.AppSettings["NumeFisier"];
            string numeFisierCumparari = ConfigurationManager.AppSettings["NumeFisier2"]; 

            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisierInstrumente = Path.Combine(locatieFisierSolutie, numeFisierInstrumente);
            string caleCompletaFisierCumparari = locatieFisierSolutie + "\\" + numeFisierCumparari;
            AdministrareInstrumente_FisierText adminInstrumente = new AdministrareInstrumente_FisierText(caleCompletaFisierInstrumente);
            AdministrareCumparareInstrumente_FisierText adminCumparari = new AdministrareCumparareInstrumente_FisierText(caleCompletaFisierCumparari);


            InstrumentMuzical instrumentNou = new InstrumentMuzical();
            
            int nrInstrumente = 0;
            int nrCumparari = 0;
            // acest apel ajuta la obtinerea numarului de studenti inca de la inceputul executiei
            // astfel incat o eventuala adaugare sa atribuie un IdStudent corect noului student
            adminInstrumente.GetInstrumente(out nrInstrumente);
            adminCumparari.GetCumparari(out nrCumparari);
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
                Console.WriteLine("O. Afisare instrumente sortate");
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

                        // Re-citirea fișierului pentru a obține lista actualizată de instrumente
                        InstrumentMuzical[] instrumenteActualizate = adminInstrumente.GetInstrumente(out nrInstrumente);

                        // Actualizarea variabilei nrInstrumente cu numărul actualizat de instrumente
                        nrInstrumente = instrumenteActualizate.Length;
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
                         // Variabila pentru a primi numarul de instrumente
                        adminInstrumente.CautareInstrumentDupaNume(numeInstrumentCautat, out nrInstrumente);
                        break;



                    case "O":
                        InstrumentMuzical[] instrumenteSortate = adminInstrumente.GetInstrumente(out _);
                        AfisareInstrumenteSortate(instrumenteSortate);
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

       

        public static void AfisareInstrumenteSortate(InstrumentMuzical[] instrumente)
        {
            var grupuriInstrumente = instrumente.GroupBy(instrument => char.ToUpper(instrument.Nume[0]));

            foreach (var grup in grupuriInstrumente.OrderBy(grup => grup.Key))
            {
                Console.WriteLine($"Instrumente care încep cu litera '{grup.Key}':");
                foreach (var instrument in grup.OrderBy(inst => inst.Nume))
                {
                    Console.WriteLine(instrument.Info());
                }
                Console.WriteLine();
            }
        }

    }
}

