using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareAngajati_FisierText : IStocareDataAngajati
    {
        string numeFisierAngajati { get; set; }
        public AdministrareAngajati_FisierText(string numeFisierAngajati)
        {
            this.numeFisierAngajati = numeFisierAngajati;
            Stream sFisierText = File.Open(numeFisierAngajati, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public void AdaugaAngajat(Angajat angajatNou)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisierAngajati, true))
                {
                    swFisierText.WriteLine(angajatNou.ConversieLaSir_PentruScriereInFisier());
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
        public ArrayList GetAngajati()
        {
            ArrayList angajati = new ArrayList();

            try
            {
                using (StreamReader sRead = new StreamReader(numeFisierAngajati))
                {
                    string line;
                    while ((line = sRead.ReadLine()) != null)
                    {
                        Angajat angajatDinFisier = new Angajat(line);
                        angajati.Add(angajatDinFisier);
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

            return angajati;
        }
        public Angajat GetAngajat(string numeEmail, string parola)
        {
            ArrayList angajati = new ArrayList();

            try
            {
                using (StreamReader sr = new StreamReader(numeFisierAngajati))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Angajat angajatDinFisier = new Angajat(line);
                        if ((angajatDinFisier.nume == numeEmail || angajatDinFisier.email == numeEmail) && angajatDinFisier.parola == parola)
                            return angajatDinFisier;
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
        public bool EditareAngajat(int index, Angajat angajatEditat)
        {
            ArrayList angajati = GetAngajati();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisierAngajati, false))
                {
                    foreach (Angajat angajat in angajati)
                    {
                        Angajat angajatPentruScrisInFisier = angajat;

                        if (angajati[index] == angajat)
                        {
                            angajatPentruScrisInFisier = angajatEditat;
                        }
                        swFisierText.WriteLine(angajatPentruScrisInFisier.ConversieLaSir_PentruScriereInFisier());
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
        public bool StergeAngajat(int index)
        {
            ArrayList angajati = GetAngajati();
            bool actualizareCuSucces = false;
            int i = 0;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisierAngajati, false))
                {
                    foreach (InstrumentMuzical angajat in angajati)
                    {
                        if (i != index)
                        {
                            swFisierText.WriteLine(angajat.ConversieLaSir_PentruScriereInFisier());
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
