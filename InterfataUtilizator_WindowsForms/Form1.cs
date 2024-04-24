using System;
using LibrarieModele;
using NivelStocareDate;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareInstrumente_FisierText adminInstrumente;

        private Label lblNume;
        private Label lblTip;
        private Label lblPret;

        private Button btnRefresh; // Butonul pentru refresh

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;

        private int numarInstrumenteAnterior = 0; // pentru a stoca numărul total de instrumente la ultimul refresh

        public Form1()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminInstrumente = new AdministrareInstrumente_FisierText(caleCompletaFisier);
            int nrInstrumente = 0;

            InstrumentMuzical[] instrumente = adminInstrumente.GetInstrumente(out nrInstrumente);

            // Setare proprietăți
            this.Size = new Size(500, 300); // Am mărit înălțimea pentru a face loc butonului și am redus poziția y a antetului tabelului
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informații instrumente muzicale";
            this.BackColor = Color.LightGray; // Setăm culoarea fundalului ferestrei

            // Adăugare buton Refresh
            btnRefresh = new Button();
            btnRefresh.Text = "Refresh";
            btnRefresh.Size = new Size(80, 30);
            btnRefresh.Location = new Point(20, 20); // Am modificat locația butonului să fie în partea de sus stânga
            btnRefresh.BackColor = Color.FromArgb(0, 192, 192); // Setăm culoarea de fundal a butonului
            btnRefresh.ForeColor = Color.White; // Setăm culoarea textului butonului
            btnRefresh.Click += BtnRefresh_Click; // Adăugăm evenimentul de click
            this.Controls.Add(btnRefresh);

            // Adăugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Left = DIMENSIUNE_PAS_X;
            lblNume.Top = 60; // Am ajustat poziția antetului tabelului în funcție de noua dimensiune a ferestrei
            lblNume.ForeColor = Color.White; // Setăm culoarea textului antetului tabelului
            lblNume.BackColor = Color.FromArgb(0, 192, 192); // Setăm culoarea de fundal a antetului tabelului
            this.Controls.Add(lblNume);

            // Adăugare control de tip Label pentru 'Tip';
            lblTip = new Label();
            lblTip.Width = LATIME_CONTROL;
            lblTip.Text = "Tip";
            lblTip.Left = 2 * DIMENSIUNE_PAS_X;
            lblTip.Top = 60; // Am ajustat poziția antetului tabelului în funcție de noua dimensiune a ferestrei
            lblTip.ForeColor = Color.White; // Setăm culoarea textului antetului tabelului
            lblTip.BackColor = Color.FromArgb(0, 192, 192); // Setăm culoarea de fundal a antetului tabelului
            this.Controls.Add(lblTip);

            // Adăugare control de tip Label pentru 'Pret';
            lblPret = new Label();
            lblPret.Width = LATIME_CONTROL;
            lblPret.Text = "Pret";
            lblPret.Left = 3 * DIMENSIUNE_PAS_X;
            lblPret.Top = 60; // Am ajustat poziția antetului tabelului în funcție de noua dimensiune a ferestrei
            lblPret.ForeColor = Color.White; // Setăm culoarea textului antetului tabelului
            lblPret.BackColor = Color.FromArgb(0, 192, 192); // Setăm culoarea de fundal a antetului tabelului
            this.Controls.Add(lblPret);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm(); // Apelăm funcția de refresh la click pe buton
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            InstrumentMuzical[] instrumente = adminInstrumente.GetInstrumente(out int nrInstrumente);

            // Adaugăm doar instrumentele noi la interfață
            for (int i = numarInstrumenteAnterior; i < nrInstrumente; i++)
            {
                Label lblNume = new Label();
                lblNume.Width = LATIME_CONTROL;
                lblNume.Text = instrumente[i].Nume;
                lblNume.Left = DIMENSIUNE_PAS_X;
                lblNume.Top = (i + 1) * DIMENSIUNE_PAS_Y + 60; // Am ajustat poziția antetului tabelului în funcție de noua dimensiune a ferestrei
                this.Controls.Add(lblNume);

                Label lblTip = new Label();
                lblTip.Width = LATIME_CONTROL;
                lblTip.Text = instrumente[i].Tip;
                lblTip.Left = 2 * DIMENSIUNE_PAS_X;
                lblTip.Top = (i + 1) * DIMENSIUNE_PAS_Y + 60; // Am ajustat poziția antetului tabelului în funcție de noua dimensiune a ferestrei
                this.Controls.Add(lblTip);

                Label lblPret = new Label();
                lblPret.Width = LATIME_CONTROL;
                lblPret.Text = instrumente[i].Pret.ToString();
                lblPret.Left = 3 * DIMENSIUNE_PAS_X;
                lblPret.Top = (i + 1) * DIMENSIUNE_PAS_Y + 60; // Am ajustat poziția antetului tabelului în funcție de noua dimensiune a ferestrei
                this.Controls.Add(lblPret);
            }

            // Actualizăm numărul total de instrumente pentru următorul refresh
            numarInstrumenteAnterior = nrInstrumente;
        }
    }
}
