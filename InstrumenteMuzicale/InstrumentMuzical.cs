﻿using System;

namespace InstrumenteMuzicale
{
    public enum Culoare
    {
        Rosu,
        Alb,
        Negru,
        Albastru,
        Verde,
        Galben,
        Portocaliu
      
    }

    [Flags]
    public enum Optiuni
    {
        Transpose = 1,
        Pedale = 2,
        Bluetooth = 4,
        USB = 8,
        Recording = 16
        
    }

    public class InstrumentMuzical
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int ID = 0;
        private const int NUME = 1;
        private const int TIP = 2;
        private const int PRET = 3;

        // data membra privata
        private string[] tipuri;

        //proprietati auto-implemented
        public int IdInstrument { get; set; } //identificator unic instrument muzical
        public string Nume { get; set; }
        public string Tip { get; set; }
        public decimal Pret { get; set; }

        public Culoare Culoare { get; set; }
        public Optiuni Optiuni { get; set; }

        //contructor implicit
        public InstrumentMuzical()
        {
            Nume = Tip = string.Empty;
        }

        //constructor cu parametri
        public InstrumentMuzical(int idInstrument, string nume, string tip, decimal pret)
        {
            this.IdInstrument = idInstrument;
            this.Nume = nume;
            this.Tip = tip;
            this.Pret = pret;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public InstrumentMuzical(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.IdInstrument = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Tip = dateFisier[TIP];
            this.Pret = Convert.ToDecimal(dateFisier[PRET]);
        }

        public string Info()
        {
            string info = $"Id:{IdInstrument} Nume:{Nume ?? " NECUNOSCUT "} Tip: {Tip ?? " NECUNOSCUT "} Pret: {Pret}";

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectInstrumentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdInstrument.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Tip ?? " NECUNOSCUT "),
                Pret.ToString());

            return obiectInstrumentPentruFisier;
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
                    Console.WriteLine(instrument.Info());
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
