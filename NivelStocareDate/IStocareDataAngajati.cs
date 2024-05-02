using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public interface IStocareDataAngajati
    {
        void AdaugaAngajat(Angajat angajatNou);
        ArrayList GetAngajati();
        Angajat GetAngajat(string numeEmail, string parola);
        bool EditareAngajat(int index, Angajat angajatEditat);
        bool StergeAngajat(int index);
    }
}
