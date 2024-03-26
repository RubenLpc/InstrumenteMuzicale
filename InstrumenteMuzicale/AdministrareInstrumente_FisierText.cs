using System;
using System.IO;
using System.Linq;

namespace InstrumenteMuzicale
{
    public class AdministrareInstrumente_FisierText
    {
        private string caleFisier;

        public AdministrareInstrumente_FisierText(string caleFisier)
        {
            this.caleFisier = caleFisier;
        }

        public void AddInstrument(InstrumentMuzical instrument)
        {
            using (StreamWriter sw = File.AppendText(caleFisier))
            {
                sw.WriteLine(instrument.ConversieLaSir_PentruFisier());
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
    }
}
