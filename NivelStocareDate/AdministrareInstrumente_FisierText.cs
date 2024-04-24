using System;
using System.IO;
using System.Linq;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareInstrumente_FisierText
    {
        private string caleFisier;
        private const int NR_MAX_INSTRUMENTE = 50;
        public AdministrareInstrumente_FisierText(string caleFisier)
        {
            this.caleFisier = caleFisier;
            Stream streamFisierText = File.Open(caleFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();

        }

        public void AddInstrument(InstrumentMuzical instrument)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(caleFisier, true))
            {
                streamWriterFisierText.WriteLine(instrument.ConversieLaSir_PentruFisier());
            }
        }

        public InstrumentMuzical[] GetInstrumente(out int nrInstrumente)
        {
            InstrumentMuzical[] instrumente = File.ReadAllLines(caleFisier)
                                            .Select(linie => new InstrumentMuzical(linie))
                                            .ToArray();

            nrInstrumente = instrumente.Length;
            return instrumente;
        }

        public void SalvareInstrumente()
        {
            Console.WriteLine("Datele au fost salvate.");
        }
        public void CautareInstrumentDupaNume(string numeInstrumentCautat, out int nrInstrumente)
        {
            InstrumentMuzical[] instrumente = GetInstrumente(out nrInstrumente);
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
