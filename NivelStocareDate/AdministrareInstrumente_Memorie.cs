using System;
using LibrarieModele;
namespace NivelStocareDate
{
    public class AdministrareInstrumente_Memorie
    {
        private InstrumentMuzical[] instrumente;
        private int nrInstrumente;

        public AdministrareInstrumente_Memorie()
        {
            instrumente = new InstrumentMuzical[100]; 
            nrInstrumente = 0;
        }

        public void AddInstrument(InstrumentMuzical instrument)
        {
            if (nrInstrumente < instrumente.Length)
            {
                instrumente[nrInstrumente++] = instrument;
            }
            else
            {
                Console.WriteLine("Numărul maxim de instrumente a fost atins.");
            }
        }

        public InstrumentMuzical[] GetInstrumente(out int nrInstrumente)
        {
            nrInstrumente = this.nrInstrumente;
            return instrumente;
        }
    }
}
