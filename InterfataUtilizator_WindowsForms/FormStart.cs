using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelStocareDate;

namespace InterfataUtilizator_WindowsForms
{
    public partial class FormStart : Form
    {
        private const string COD_ACCES = "12345";

        IStocareDataAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();


        public FormStart()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            makeInvisible();
        }

        private void buttonAngajat_Click(object sender, EventArgs e)
        {
            buttonAngajat.Visible = false;
            buttonClient.Visible = false;
            buttonIesire.Visible = false;


            makeVizible();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }

        private void buttonAngajatNou_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Pentru a crea un cont nou trebuie să introduceți codul de acces!";
            makeVizibleInvizibleParolaUitata(false);
            labelStatus.Visible = true;
            textBoxCodAcces.Visible = true;
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Pentru a afla parola dvs., completați câmpurile de mai jos, apoi apăsați ,,Info''!";
            textBoxContNouEmail.Text = string.Empty;
            textBoxContNouNume.Text = string.Empty;
            makeVizibleInvizibleParolaUitata(true);

            textBoxCodAcces.Visible = false;
            textBoxContNouParola.Visible = false;
            labelContNouParola.Visible = false;
            buttonAdaugaAngajat.Visible = false;
        }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {
            textBoxParola.MaxLength = 16;
            textBoxParola.PasswordChar = '*';
            textBoxParola.TextAlign = HorizontalAlignment.Left;
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonConectare_Click(object sender, EventArgs e)
        {
            Angajat angajatConectare = adminAngajati.GetAngajat(textBoxEmailNume.Text, textBoxParola.Text);

            if (angajatConectare != null)
            {
                makeInvisible();
                textBoxEmailNume.Text = string.Empty;
                textBoxParola.Text = string.Empty;
                labelStatus.Text = string.Empty;

                buttonAngajat.Visible = true;
                buttonClient.Visible = true;
                buttonIesire.Visible = true;

                FormAngajat formAngajat = new FormAngajat(angajatConectare.nume);
                formAngajat.Show();

            }
            else
            {
                textBoxEmailNume.Text = string.Empty;
                textBoxParola.Text = string.Empty;
                labelCredentialeStatus.Text = "Datele introduse sunt incorecte!";
            }

        }
        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void labelCreazaStatus_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodAcces_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodAcces.Text == COD_ACCES)
            {
                textBoxContNouEmail.Visible = true;
                textBoxContNouNume.Visible = true;
                textBoxContNouParola.Visible = true;
                labelContNouEmail.Visible = true;
                labelContNouNume.Visible = true;
                labelContNouParola.Visible = true;
                buttonAdaugaAngajat.Visible = true;

                textBoxContNouParola.MaxLength = 16;
                textBoxContNouParola.PasswordChar = '*';
                textBoxContNouParola.TextAlign = HorizontalAlignment.Left;
            }
            else
            {
                textBoxContNouEmail.Visible = false;
                textBoxContNouNume.Visible = false;
                textBoxContNouParola.Visible = false;
                labelContNouEmail.Visible = false;
                labelContNouNume.Visible = false;
                labelContNouParola.Visible = false;
                labelStatus.Visible = true;
            }
        }

        private void buttonAdaugaAngajat_Click(object sender, EventArgs e)
        {
            if (DateValide())
            {
                Angajat angajatNou = new Angajat(textBoxContNouEmail.Text, textBoxContNouNume.Text, textBoxContNouParola.Text);
                adminAngajati.AdaugaAngajat(angajatNou);
                labelStatus.Text = "Contul dvs. a fost creat cu succes!";

                textBoxContNouEmail.Visible = false;
                textBoxContNouNume.Visible = false;
                textBoxContNouParola.Visible = false;
                labelContNouEmail.Visible = false;
                labelContNouNume.Visible = false;
                labelContNouParola.Visible = false;
                buttonAdaugaAngajat.Visible = false;
                labelStatus.Visible = true;
                labelStatus.Visible = false;
                textBoxCodAcces.Visible = false;
            }
            else
            {
                labelStatus.Text = "Contul dvs. nu a fost creat cu succes! Vă rugăm să mai încercați o dată!";
                buttonAdaugaAngajat.Visible = false;
                textBoxCodAcces.Visible = false;
                textBoxContNouEmail.Text = string.Empty;
                textBoxContNouNume.Text = string.Empty;
                textBoxContNouParola.Text = string.Empty;
            }
            textBoxCodAcces.Text = string.Empty;
        }
        private bool DateValide()
        {
            bool isInt = Int32.TryParse(textBoxContNouEmail.Text, out int result);
            if (!isInt && textBoxContNouEmail.Text != string.Empty)
            {

            }
            else
            {
                return false;
            }

            isInt = Int32.TryParse(textBoxContNouNume.Text, out result);
            if (!isInt && textBoxContNouNume.Text != string.Empty)
            {
            }
            else
            {
                return false;
            }
            isInt = Int32.TryParse(textBoxContNouParola.Text, out result);
            if (!isInt && textBoxContNouParola.Text != string.Empty)
            {
            }
            else
            {
                return false;
            }
            return true;
        }

        private void textBoxContNouEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContNouNume_TextChanged(object sender, EventArgs e)
        {

        }
        private void makeVizible()
        {
            textBoxEmailNume.Visible = true;
            textBoxParola.Visible = true;

            labelEmailNume.Visible = true;
            labelParola.Visible = true;
            labelCredentialeStatus.Visible = true;
            labelParolaUitata.Visible = true;

            buttonConectare.Visible = true;
            buttonAngajatNou.Visible = true;
            buttonInapoi.Visible = true;
        }
        private void makeInvisible()
        {
            textBoxEmailNume.Visible = false;
            textBoxParola.Visible = false;
            textBoxCodAcces.Visible = false;
            textBoxContNouEmail.Visible = false;
            textBoxContNouNume.Visible = false;
            textBoxContNouParola.Visible = false;

            labelEmailNume.Visible = false;
            labelParola.Visible = false;
            labelCredentialeStatus.Visible = false;
            labelParolaUitata.Visible = false;
            labelStatus.Visible = false;
            labelContNouEmail.Visible = false;
            labelContNouNume.Visible = false;
            labelContNouParola.Visible = false;


            buttonConectare.Visible = false;
            buttonAngajatNou.Visible = false;
            buttonAflaParola.Visible = false;
            buttonAdaugaAngajat.Visible = false;
            buttonInapoi.Visible = false;
        }

        private void buttonAflaParola_Click(object sender, EventArgs e)
        {
            ArrayList angajati = adminAngajati.GetAngajati();

            foreach (Angajat angajat in angajati)
            {
                if (textBoxContNouEmail.Text == angajat.email)
                {

                    labelStatus.Text = "Angajatul/a cu numele " + angajat.nume + " și adresa de E-mail " + angajat.email + " are parola: " + angajat.parola;
                    makeVizibleInvizibleParolaUitata(false);
                    labelStatus.Visible = true;
                    break;
                }
                else
                {
                    if (textBoxContNouEmail.Text != string.Empty)
                    {
                        labelStatus.Text = "Angajatul/a cu adresa de E-mail " + textBoxContNouEmail.Text + " nu există!";
                    }
                    else if (textBoxContNouNume.Text != string.Empty)
                    {
                        labelStatus.Text = "Angajatul/a cu numele " + textBoxContNouNume.Text + " nu există!";
                    }
                    else if (textBoxContNouEmail.Text == string.Empty && textBoxContNouNume.Text == string.Empty)
                    {
                        labelStatus.Text = "Pentru a afla parola dvs., completați câmpurile de mai jos, apoi apăsați ,,Info''!";
                    }

                }
                makeVizibleInvizibleParolaUitata(false);
                labelStatus.Visible = true;
            }
        }
        private void makeVizibleInvizibleParolaUitata(bool trueFlase)
        {

            textBoxContNouEmail.Visible = trueFlase;
            textBoxContNouNume.Visible = trueFlase;
            textBoxCodAcces.Visible = trueFlase;
            textBoxContNouParola.Visible = trueFlase;

            labelStatus.Visible = trueFlase;
            labelContNouEmail.Visible = trueFlase;
            labelContNouNume.Visible = trueFlase;
            labelContNouParola.Visible = trueFlase;
            buttonAflaParola.Visible = trueFlase;
            buttonAdaugaAngajat.Visible = trueFlase;
        }

        private void textBoxContNouParola_TextChanged(object sender, EventArgs e)
        {
            textBoxContNouParola.MaxLength = 16;
            textBoxContNouParola.PasswordChar = '*';
            textBoxContNouParola.TextAlign = HorizontalAlignment.Left;
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            makeInvisible();

            buttonAngajat.Visible = true;
            buttonClient.Visible = true;
            buttonIesire.Visible = true;
        }

        private void labelEmailNume_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
