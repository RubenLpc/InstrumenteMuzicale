﻿using System;
using System.Collections;
using System.IO;
using System.Linq;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareInstrumente_FisierText: IStocareDataInstrumente
    {
        string numeFisierInstrumente { get; set; }
        public AdministrareInstrumente_FisierText(string numeFisierInstrumente)
        {
            this.numeFisierInstrumente = numeFisierInstrumente;
            Stream sFisierText = File.Open(numeFisierInstrumente, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public void AdaugaInstrument(InstrumentMuzical instrumentNou)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisierInstrumente, true))
                {
                    swFisierText.WriteLine(instrumentNou.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }
        }
        public ArrayList GetInstrumente()
        {
            ArrayList instrumente = new ArrayList();

            try
            {
                using (StreamReader sRead = new StreamReader(numeFisierInstrumente))
                {
                    string line;
                    while ((line = sRead.ReadLine()) != null)
                    {
                        InstrumentMuzical instrumentDinFisier = new InstrumentMuzical(line);
                        instrumente.Add(instrumentDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }

            return instrumente;
        }
        public InstrumentMuzical GetInstrument(string nume)
        {
            ArrayList instrumente = new ArrayList();

            try
            {
                using (StreamReader sr = new StreamReader(numeFisierInstrumente))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        InstrumentMuzical studentDinFisier = new InstrumentMuzical(line);
                        if (studentDinFisier.Nume == nume)
                            return studentDinFisier;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }

            return null;
        }
        public bool EditareInstrument(int index, InstrumentMuzical instrumentEditat)
        {
            ArrayList instrumente = GetInstrumente();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisierInstrumente, false))
                {
                    foreach (InstrumentMuzical instrument in instrumente)
                    {
                        InstrumentMuzical instrumentPentruScrisInFisier = instrument;

                        if (instrumente[index] == instrument)
                        {
                            instrumentPentruScrisInFisier = instrumentEditat;
                        }
                        swFisierText.WriteLine(instrumentPentruScrisInFisier.ConversieLaSir_PentruScriereInFisier());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }
            return actualizareCuSucces;
        }
        public bool StergereInstrument(int index)
        {
            ArrayList instrumente = GetInstrumente();
            bool actualizareCuSucces = false;
            int i = 0;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisierInstrumente, false))
                {
                    foreach (InstrumentMuzical instrument in instrumente)
                    {
                        if (i != index)
                        {
                            swFisierText.WriteLine(instrument.ConversieLaSir_PentruScriereInFisier());
                        }
                        i++;
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }
            return actualizareCuSucces;
        }
    }
}
