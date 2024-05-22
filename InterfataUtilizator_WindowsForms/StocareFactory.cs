using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelStocareDate;

namespace InterfataUtilizator_WindowsForms
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_INSTRUMENTE = "NumeFisierInstrumente";
        private const string NUME_FISIER_ANGAJATI = "NumeFisierAngajati";

        public static IStocareDataInstrumente GetAdministratorStocareInstrumente()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierInstrumente = ConfigurationManager.AppSettings[NUME_FISIER_INSTRUMENTE];

            if (formatSalvare != null)
            {
                return new AdministrareInstrumente_FisierText(numeFisierInstrumente + "." + formatSalvare);
            }
            return null;
        }
        public static IStocareDataAngajati GetAdministratorStocareAngajati()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierAngajati = ConfigurationManager.AppSettings[NUME_FISIER_ANGAJATI];

            if (formatSalvare != null)
            {
                return new AdministrareAngajati_FisierText(numeFisierAngajati + "." + formatSalvare);
            }
            return null;
        }
    }
}
