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
    public partial class FormClient : Form
    {
        IStocareDataInstrumente adminInstrumente = StocareFactory.GetAdministratorStocareInstrumente();
        public FormClient()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            buttonAdauga.Visible = false;
            afisareInstrumente();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCantitate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxInstrumente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxInstrumente.SelectedIndex != -1)
            {
                ArrayList instrumente = adminInstrumente.GetInstrumente();
                InstrumentMuzical instrumentSelectat = (InstrumentMuzical)instrumente[listBoxInstrumente.SelectedIndex];
                labelInstrumentSelectatStatus.Text = instrumentSelectat.ConversieLaSir_PentruAfisare();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (listBoxInstrumente.SelectedIndex != -1)
            {
                ArrayList instrumente = adminInstrumente.GetInstrumente();
                InstrumentMuzical instrumentSelectat = (InstrumentMuzical)instrumente[listBoxInstrumente.SelectedIndex];

                bool isInt = Int32.TryParse(textBoxCantitate.Text, out int cantitate);
                if (cantitate <= instrumentSelectat.cantitate && isInt && cantitate > 0)
                {
                    labelCantitate.BackColor = Color.Green;
                    buttonAdauga.Visible = true;
                }
                else
                {
                    labelCantitate.BackColor = Color.Red;
                    buttonAdauga.Visible = false;

                }
            }
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFinalizareComanda_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var random = rand.Next();

            DialogResult res = MessageBox.Show("Sunteți sigur că doriți să finalizați comanda nr. (" + random + ")?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                listBoxInstrumenteComanda.Items.Clear();
                labelComandaStatus.Text = "Status comandă: Comanda dvs. cu nr. " + random + " a fost finalizată cu succes!";
            }
            else
            {
                labelComandaStatus.Text = "Status comandă: Comanda nu a fost finalizată cu succes! Vă rugăm să încercați încă o dată!";
            }
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (listBoxInstrumente.SelectedIndex != -1)
            {
                int i = listBoxInstrumente.SelectedIndex;
                ArrayList instrumente = adminInstrumente.GetInstrumente();
                InstrumentMuzical instrumentSelectat = (InstrumentMuzical)instrumente[i];
                InstrumentMuzical instrumentComanda = instrumentSelectat;

                bool isInt = Int32.TryParse(textBoxCantitate.Text, out int cantitate);
                if ((cantitate <= instrumentSelectat.cantitate) && isInt && (textBoxCantitate.Text != string.Empty))
                {
                    labelCantitate.BackColor = Color.Green;

                    instrumentSelectat.cantitate -= cantitate;
                    adminInstrumente.EditareInstrument(i, instrumentSelectat);
                    instrumentComanda.cantitate = cantitate;

                    listBoxInstrumenteComanda.Items.Add(instrumentComanda.ConversieLaSir_PentruAfisare());

                    labelInstrumentSelectatStatus.Text = "Instrumentul a fost adăugat cu succes!";
                }
                else
                {
                    labelCantitate.BackColor = Color.Red;
                    labelInstrumentSelectatStatus.Text = "Instrumentul nu a fost adăugat cu succes!";
                }
            }
            afisareInstrumente();
            buttonAdauga.Visible = false;
        }
        private void afisareInstrumente()
        {
            ArrayList instrumente = adminInstrumente.GetInstrumente();

            listBoxInstrumente.Items.Clear();
            foreach (InstrumentMuzical m in instrumente)
            {
                listBoxInstrumente.Items.Add(((InstrumentMuzical)m).ConversieLaSir_PentruAfisare());
            }
        }

        private void labelComandaStatus_Click(object sender, EventArgs e)
        {

        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }
    }
}
