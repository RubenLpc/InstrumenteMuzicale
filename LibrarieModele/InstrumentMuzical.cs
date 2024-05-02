using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{  public class InstrumentMuzical
    {       //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int ID = 0;
        private const int COD = 1;
        private const int CANTITATE = 2;
        private const int NUME = 3;
        private const int TIP = 4;
        private const int PRET = 5;

        // data membra privata
        public enum TipInstrument
        {
            Coardă = 1,
            Clape = 2,
            Suflat = 3,
            Percuție = 4,
            End = 5,
        }

        //proprietati auto-implemented
        public static int IdUltimul { get; set; }
        public int Id { get; set; }
        public string Nume { get; set; }
        public int cod { get; set; }
        public decimal Pret { get; set; }
        public int cantitate { get; set; }
        public TipInstrument Tip { get; set; }

        //contructor implicit
        public InstrumentMuzical()
        {
            Nume = string.Empty;
            cod = 0;
            IdUltimul++;
            Id = IdUltimul;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public InstrumentMuzical(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.Id = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Tip = (TipInstrument)Convert.ToInt32(dateFisier[TIP]);
            this.Pret = Convert.ToDecimal(dateFisier[PRET]);
            cantitate = Convert.ToInt32(dateFisier[CANTITATE]);
            IdUltimul = Id;
            this.cod = Convert.ToInt32(dateFisier[COD]);
        }

        public string ConversieLaSir_PentruAfisare()
        {
            string info = $"Id:{Id}, cod: {cod}, cantitate: {cantitate} Nume:{Nume ?? " NECUNOSCUT "} Tip: {(TipInstrument)Tip} Pret: {Pret}";

            return info;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", SEPARATOR_PRINCIPAL_FISIER, Id, cod, cantitate, Nume, (int)Tip, Pret);
        }


    }
}
