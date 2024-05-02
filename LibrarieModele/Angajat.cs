using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Angajat
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int EMAIL = 1;
        private const int NUME = 2;
        private const int PAROLA = 3;

        public static int idUltimul { get; set; }
        public int id { get; set; }
        public string nume { get; set; }
        public string email { get; set; }
        public string parola { get; set; }

        public Angajat()
        {
            nume = string.Empty;
            email = string.Empty;
            parola = string.Empty;
            idUltimul++;
            id = idUltimul;
        }
        public Angajat(string email, string nume, string parola)
        {
            this.email = email;
            this.nume = nume;
            this.parola = parola;
            idUltimul++;
            id = idUltimul;
        }
        public Angajat(string linieFisier)
        {
            string[] dataFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            id = Convert.ToInt32(dataFisier[ID]);
            email = dataFisier[EMAIL];
            nume = dataFisier[NUME];
            parola = dataFisier[PAROLA];
        }

        public string ConversieLaSir_PentruAfisare()
        {
            return $"id: {id}, e-mail: {email}, nume: {nume}, parola: {parola}";
        }
        public string ConversieLaSir_PentruScriereInFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}", SEPARATOR_PRINCIPAL_FISIER, id, email, nume, parola);
        }
    }
}
