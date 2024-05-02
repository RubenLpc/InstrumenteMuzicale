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
    public partial class FormAngajat : Form
    {
        IStocareDataInstrumente adminInstrumente = StocareFactory.GetAdministratorStocareInstrumente();
        public FormAngajat(string numeAngajat)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            labelAngajatConectat.Text = "Angajatul/a: " + numeAngajat + " este conectat/ă!";
            buttonEditare.Visible = true;
            buttonStergere.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            afisareMedicamte();
            FreeData();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            InstrumentMuzical instrumentNou = new InstrumentMuzical();

            if (dataValide() == true)
            {
                instrumentNou.Nume = textBoxNume.Text;
                instrumentNou.cod = Convert.ToInt32(textBoxCod.Text);
                instrumentNou.Pret = Convert.ToDecimal(textBoxPret.Text);
                instrumentNou.cantitate = Convert.ToInt32(textBoxCantitate.Text);
                instrumentNou.Tip = getTip();
               adminInstrumente.AdaugaInstrument(instrumentNou);

                labelNume.BackColor = Color.WhiteSmoke;
                labelCantitate.BackColor = Color.WhiteSmoke;
                labelTip.BackColor = Color.WhiteSmoke;
                labelPret.BackColor = Color.WhiteSmoke;
                labelCantitate.BackColor = Color.WhiteSmoke;
                labelCod.BackColor = Color.WhiteSmoke;

                labelStatus.Text = "Produsul a fost adăugat cu succes!";
            }
            else
            {
                labelStatus.Text = "Produsul nu a fost adăugat cu succes!";
            }
            FreeData();
        }
        private void FormAngajat_Load(object sender, EventArgs e)
        {

        }
        private InstrumentMuzical.TipInstrument getTip()
        {
            if (radioButtonCoarda.Checked)
            {
                return InstrumentMuzical.TipInstrument.Coardă;
            }
            else if (radioButtonClape.Checked)
            {
                return InstrumentMuzical.TipInstrument.Clape;
            }
            else if (radioButtonSuflat.Checked)
            {
                return InstrumentMuzical.TipInstrument.Suflat;
            }
            else if (radioButtonPercutie.Checked)
            {
                return InstrumentMuzical.TipInstrument.Percuție;
            }
            return InstrumentMuzical.TipInstrument.End;
        }
        private bool dataValide()
        {

            bool isInt = Int32.TryParse(textBoxNume.Text, out int result);
            if (!isInt && textBoxNume.Text != string.Empty)
            {
                labelNume.BackColor = Color.Green;
            }
            else
            {
                labelNume.BackColor = Color.Red;
                return false;
            }

            if (getTip() != InstrumentMuzical.TipInstrument.End)
            {
                labelTip.BackColor = Color.Green;
            }
            else
            {
                labelTip.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxCod.Text, out result);
            if (isInt && textBoxCod.Text != string.Empty)
            {
                labelCod.BackColor = Color.Green;
            }
            else
            {
                labelCod.BackColor = Color.Red;
                return false;
            }

            bool isDec = decimal.TryParse(textBoxPret.Text, out decimal result1);
            if (isDec && textBoxPret.Text != string.Empty)
            {
                labelPret.BackColor = Color.Green;
            }
            else
            {
                labelPret.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxCantitate.Text, out result);
            if (isInt && textBoxCantitate.Text != string.Empty)
            {
                labelCantitate.BackColor = Color.Green;
            }
            else
            {
                labelCantitate.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void comboBoxCantitate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxInstrumente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxInstrumente.SelectedIndex != -1)
            {
                buttonAdauga.Visible = true;
                buttonCauta.Visible = true;
                buttonEditare.Visible = true;
                buttonStergere.Visible = true;

                ArrayList instrumente = adminInstrumente.GetInstrumente();
                InstrumentMuzical instrumentSelectat = (InstrumentMuzical)instrumente[listBoxInstrumente.SelectedIndex];

                textBoxNume.Text = instrumentSelectat.Nume;

                if (instrumentSelectat.Tip == InstrumentMuzical.TipInstrument.Coardă)
                    radioButtonCoarda.Checked = true;
                else if (instrumentSelectat.Tip == InstrumentMuzical.TipInstrument.Clape)
                    radioButtonClape.Checked = true;
                else if (instrumentSelectat.Tip == InstrumentMuzical.TipInstrument.Suflat)
                    radioButtonSuflat.Checked = true;
                else if (instrumentSelectat.Tip == InstrumentMuzical.TipInstrument.Percuție)
                    radioButtonPercutie.Checked = true;
                textBoxCod.Text = Convert.ToString(instrumentSelectat.cod);
                textBoxPret.Text = Convert.ToString(instrumentSelectat.Pret);
                textBoxCantitate.Text = Convert.ToString(instrumentSelectat.cantitate);
            }
        }

        private void buttonEditare_Click(object sender, EventArgs e)
        {
            buttonStergere.Visible = true;
            buttonCauta.Visible = true;
            buttonAdauga.Visible = true;

            int index = listBoxInstrumente.SelectedIndex;
            if (listBoxInstrumente.SelectedIndex != -1)
            {
                ArrayList instrumente = adminInstrumente.GetInstrumente();
                foreach (InstrumentMuzical instrumentEditat in instrumente)
                {
                    if (dataValide() == true && instrumente[index] == instrumentEditat)
                    {
                        instrumentEditat.Nume = textBoxNume.Text;
                        instrumentEditat.cod = Convert.ToInt32(textBoxCod.Text);
                        instrumentEditat.Pret = Convert.ToDecimal(textBoxPret.Text);
                        instrumentEditat.cantitate = Convert.ToInt32(textBoxCantitate.Text);
                        instrumentEditat.Tip = getTip();

                        adminInstrumente.EditareInstrument(index, instrumentEditat);

                        labelStatus.Text = "Instrumentul a fost editat cu succes!";
                        continue;
                    }
                    else
                    {
                        labelStatus.Text = "Instrumentul nu a fost editat cu succes!";
                        continue;
                    }
                }
            }
            buttonEditare.Visible = true;
            FreeData();
        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {
            buttonEditare.Visible = true;
            buttonCauta.Visible = true;
            buttonAdauga.Visible = true;

            int index = listBoxInstrumente.SelectedIndex;
            if (listBoxInstrumente.SelectedIndex != -1)
            {
                FreeData();
                DialogResult res = MessageBox.Show("Sunteți sigur că doriți să ștergeți instrumentul selectat?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    if (adminInstrumente.StergereInstrument(index) == true)
                    {
                        labelStatus.Text = "Instrumentul a fost șters cu succes!";
                        afisareMedicamte();

                    }
                }
                else
                {
                    labelStatus.Text = "Instrumentul nu a fost șters cu succes!";
                }
            }
            buttonStergere.Visible = true;
            FreeData();
        }

        private void button1_Cautare(object sender, EventArgs e)
        {
            buttonEditare.Visible = true;
            buttonStergere.Visible = true;
            buttonAdauga.Visible = true;

            bool isInt = Int32.TryParse(textBoxNume.Text, out int result);
            if (!isInt && textBoxNume.Text != string.Empty)
            {

                InstrumentMuzical instrumentCautat = adminInstrumente.GetInstrument(textBoxNume.Text);
                if (instrumentCautat != null)
                {
                    listBoxInstrumente.Items.Clear();
                    listBoxInstrumente.Items.Add(instrumentCautat.ConversieLaSir_PentruAfisare());
                    labelStatus.Text = "Instrumentul căutat a fost găsit cu succes!";
                }
                else
                {
                    labelStatus.Text = "Instrumentul căutat nu există!";
                }

            }
            else
            {
                labelNume.BackColor = Color.Red;
            }
            buttonAdauga.Visible = true;
            FreeData();
        }
        private void FreeData()
        {
            textBoxNume.Text = string.Empty;
            textBoxCod.Text = string.Empty;
            textBoxPret.Text = string.Empty;
            textBoxCantitate.Text = string.Empty;
            radioButtonCoarda.Checked = false;
            radioButtonClape.Checked = false;
            radioButtonSuflat.Checked = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void afisareMedicamte()
        {
            ArrayList instrumente = adminInstrumente.GetInstrumente();

            listBoxInstrumente.Items.Clear();
            foreach (InstrumentMuzical m in instrumente)
            {
                listBoxInstrumente.Items.Add(((InstrumentMuzical)m).ConversieLaSir_PentruAfisare());
            }
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDataExpirarii_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
