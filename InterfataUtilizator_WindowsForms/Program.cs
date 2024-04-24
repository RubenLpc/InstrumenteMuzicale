using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelStocareDate;

namespace InterfataUtilizator_WindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crearea și afișarea formularului pentru adăugarea de studenți
            FormularInstrumente form1 = new FormularInstrumente();
            form1.Show();

            // Afișarea formularului pentru afișarea și gestionarea studenților
            Application.Run(new Form1());
        }
    }

    public class FormularInstrumente : Form
    {
        private Label lblNumeInstrument;
        private TextBox txtNumeInstrument;

        private Label lblTipInstrument;
        private TextBox txtTipInstrument;

        private Label lblPretInstrument;
        private TextBox txtPretInstrument;

        private Button btnAdaugaInstrument;
        private Label lblInstrumentAdaugat;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;

        public FormularInstrumente()
        {
            // Configurarea aspectului formularului
            this.Size = new System.Drawing.Size(400, 250);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Formular Adăugare Instrument Muzical";

            // Adăugarea controlului de tip Label pentru 'Nume Instrument'
            lblNumeInstrument = new Label();
            lblNumeInstrument.Width = LATIME_CONTROL;
            lblNumeInstrument.Text = "Nume Instrument:";
            lblNumeInstrument.BackColor = Color.LightYellow;
            this.Controls.Add(lblNumeInstrument);

            // Adăugarea controlului de tip TextBox pentru 'Nume Instrument'
            txtNumeInstrument = new TextBox();
            txtNumeInstrument.Width = LATIME_CONTROL;
            txtNumeInstrument.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtNumeInstrument);

            // Adăugarea controlului de tip Label pentru 'Tip Instrument'
            lblTipInstrument = new Label();
            lblTipInstrument.Width = LATIME_CONTROL;
            lblTipInstrument.Text = "Tip Instrument:";
            lblTipInstrument.Top = DIMENSIUNE_PAS_Y;
            lblTipInstrument.BackColor = Color.LightYellow;
            this.Controls.Add(lblTipInstrument);

            // Adăugarea controlului de tip TextBox pentru 'Tip Instrument'
            txtTipInstrument = new TextBox();
            txtTipInstrument.Width = LATIME_CONTROL;
            txtTipInstrument.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtTipInstrument);

            // Adăugarea controlului de tip Label pentru 'Pret Instrument'
            lblPretInstrument = new Label();
            lblPretInstrument.Width = LATIME_CONTROL;
            lblPretInstrument.Text = "Pret Instrument:";
            lblPretInstrument.Top = 2 * DIMENSIUNE_PAS_Y;
            lblPretInstrument.BackColor = Color.LightYellow;
            this.Controls.Add(lblPretInstrument);

            // Adăugarea controlului de tip TextBox pentru 'Pret Instrument'
            txtPretInstrument = new TextBox();
            txtPretInstrument.Width = LATIME_CONTROL;
            txtPretInstrument.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 2 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtPretInstrument);

            // Adăugarea controlului de tip Button pentru adăugarea instrumentului
            btnAdaugaInstrument = new Button();
            btnAdaugaInstrument.Width = LATIME_CONTROL;
            btnAdaugaInstrument.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 3 * DIMENSIUNE_PAS_Y);
            btnAdaugaInstrument.Text = "Adaugă Instrument";
            btnAdaugaInstrument.Click += OnButtonClicked;
            this.Controls.Add(btnAdaugaInstrument);

            // Adăugarea unui label pentru afișarea informațiilor despre instrumentul adăugat
            lblInstrumentAdaugat = new Label();
            lblInstrumentAdaugat.Width = 400;
            lblInstrumentAdaugat.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 4 * DIMENSIUNE_PAS_Y);
            lblInstrumentAdaugat.BackColor = Color.LightYellow;
            lblInstrumentAdaugat.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblInstrumentAdaugat);

            // Închiderea aplicației când se închide formularul
            this.FormClosed += OnFormClosed;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            AdministrareInstrumente_FisierText adminInstrumente = new AdministrareInstrumente_FisierText(caleCompletaFisier);
            string numeInstrument = txtNumeInstrument.Text;
            string tipInstrument = txtTipInstrument.Text;
            decimal pretInstrument;

            // Verificăm dacă prețul introdus este un număr valid
            if (!decimal.TryParse(txtPretInstrument.Text, out pretInstrument))
            {
                MessageBox.Show("Vă rugăm introduceți un preț valid pentru instrument.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificăm dacă numele și tipul instrumentului sunt completate
            if (string.IsNullOrWhiteSpace(numeInstrument) || string.IsNullOrWhiteSpace(tipInstrument))
            {
                MessageBox.Show("Vă rugăm să completați câmpurile pentru nume și tipul instrumentului.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificăm dacă prețul instrumentului este mai mare sau egal cu zero
            if (pretInstrument < 0)
            {
                MessageBox.Show("Prețul instrumentului trebuie să fie mai mare sau egal cu zero.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dacă toate validările sunt trecute, creăm și adăugăm instrumentul
            InstrumentMuzical instrument = new InstrumentMuzical(1, numeInstrument, tipInstrument, pretInstrument);
            adminInstrumente.AddInstrument(instrument);

            // Afișarea informațiilor despre instrumentul adăugat
            lblInstrumentAdaugat.Text = "Instrument adăugat: " + instrument.Info();
        }


        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
