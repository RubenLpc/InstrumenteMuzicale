using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public interface IStocareDataInstrumente
    {
        void AdaugaInstrument(InstrumentMuzical instrumentNou);
        ArrayList GetInstrumente();
        InstrumentMuzical GetInstrument(string nume);
        bool EditareInstrument(int index, InstrumentMuzical instrumenteEditata);
        bool StergereInstrument(int index);
    }
}
