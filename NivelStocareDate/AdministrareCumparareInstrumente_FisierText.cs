﻿using System;
using System.IO;
using System.Linq;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareCumparareInstrumente_FisierText
    {
        private string numeFisier;

        public AdministrareCumparareInstrumente_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AdaugaCumparare(CumparareInstrumentMuzical cumparare)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(cumparare.ConversieLaSir_PentruFisier());
            }
        }

        public CumparareInstrumentMuzical[] GetCumparari(out int nrCumparari)
        {
            CumparareInstrumentMuzical[] cumparari = new CumparareInstrumentMuzical[0];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrCumparari = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    // Se creează un obiect de tip CumparareInstrumentMuzical pe baza datelor din linia citită
                    cumparari = cumparari.Append(new CumparareInstrumentMuzical(linieFisier)).ToArray();
                    nrCumparari++;
                }
            }

            return cumparari;
        }

        public void SalvareCumparareInstrumente()
        {
            Console.WriteLine("Datele despre cumpărările de instrumente au fost salvate.");
        }
    }
}