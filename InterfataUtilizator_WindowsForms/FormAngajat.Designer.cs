namespace InterfataUtilizator_WindowsForms
{
    partial class FormAngajat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInfoAdauga = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.labelPret = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.radioButtonCoarda = new System.Windows.Forms.RadioButton();
            this.radioButtonClape = new System.Windows.Forms.RadioButton();
            this.radioButtonSuflat = new System.Windows.Forms.RadioButton();
            this.radioButtonPercutie = new System.Windows.Forms.RadioButton();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.buttonEditare = new System.Windows.Forms.Button();
            this.buttonStergere = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.listBoxInstrumente = new System.Windows.Forms.ListBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.openFileDialogSterge = new System.Windows.Forms.OpenFileDialog();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.labelAngajatConectat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfoAdauga
            // 
            this.labelInfoAdauga.AutoSize = true;
            this.labelInfoAdauga.Location = new System.Drawing.Point(323, 99);
            this.labelInfoAdauga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoAdauga.Name = "labelInfoAdauga";
            this.labelInfoAdauga.Size = new System.Drawing.Size(149, 19);
            this.labelInfoAdauga.TabIndex = 0;
            this.labelInfoAdauga.Text = "Adăugați un instrument:";
            this.labelInfoAdauga.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(360, 157);
            this.labelNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(46, 19);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(361, 232);
            this.labelCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(36, 19);
            this.labelCod.TabIndex = 2;
            this.labelCod.Text = "Cod";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(360, 190);
            this.labelTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(28, 19);
            this.labelTip.TabIndex = 3;
            this.labelTip.Text = "Tip";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(327, 348);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(100, 34);
            this.buttonAdauga.TabIndex = 4;
            this.buttonAdauga.Text = "Adăugare";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(361, 269);
            this.labelPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(34, 19);
            this.labelPret.TabIndex = 5;
            this.labelPret.Text = "Preț";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(478, 150);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(148, 26);
            this.textBoxNume.TabIndex = 6;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // radioButtonCoarda
            // 
            this.radioButtonCoarda.AutoSize = true;
            this.radioButtonCoarda.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonCoarda.Location = new System.Drawing.Point(478, 188);
            this.radioButtonCoarda.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCoarda.Name = "radioButtonCoarda";
            this.radioButtonCoarda.Size = new System.Drawing.Size(73, 23);
            this.radioButtonCoarda.TabIndex = 7;
            this.radioButtonCoarda.TabStop = true;
            this.radioButtonCoarda.Text = "Coardă";
            this.radioButtonCoarda.UseVisualStyleBackColor = false;
            // 
            // radioButtonClape
            // 
            this.radioButtonClape.AutoSize = true;
            this.radioButtonClape.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonClape.Location = new System.Drawing.Point(571, 188);
            this.radioButtonClape.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonClape.Name = "radioButtonClape";
            this.radioButtonClape.Size = new System.Drawing.Size(63, 23);
            this.radioButtonClape.TabIndex = 8;
            this.radioButtonClape.TabStop = true;
            this.radioButtonClape.Text = "Clape";
            this.radioButtonClape.UseVisualStyleBackColor = false;
            // 
            // radioButtonSuflat
            // 
            this.radioButtonSuflat.AutoSize = true;
            this.radioButtonSuflat.Location = new System.Drawing.Point(754, 188);
            this.radioButtonSuflat.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSuflat.Name = "radioButtonSuflat";
            this.radioButtonSuflat.Size = new System.Drawing.Size(61, 23);
            this.radioButtonSuflat.TabIndex = 9;
            this.radioButtonSuflat.TabStop = true;
            this.radioButtonSuflat.Text = "Suflat";
            this.radioButtonSuflat.UseVisualStyleBackColor = true;
            // 
            // radioButtonPercutie
            // 
            this.radioButtonPercutie.AutoSize = true;
            this.radioButtonPercutie.Location = new System.Drawing.Point(662, 188);
            this.radioButtonPercutie.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPercutie.Name = "radioButtonPercutie";
            this.radioButtonPercutie.Size = new System.Drawing.Size(76, 23);
            this.radioButtonPercutie.TabIndex = 10;
            this.radioButtonPercutie.TabStop = true;
            this.radioButtonPercutie.Text = "Percuție";
            this.radioButtonPercutie.UseVisualStyleBackColor = true;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(478, 225);
            this.textBoxCod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(148, 26);
            this.textBoxCod.TabIndex = 11;
            this.textBoxCod.TextChanged += new System.EventHandler(this.textBoxCod_TextChanged);
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(478, 263);
            this.textBoxPret.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(148, 26);
            this.textBoxPret.TabIndex = 12;
            this.textBoxPret.TextChanged += new System.EventHandler(this.textBoxPret_TextChanged);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(327, 430);
            this.buttonAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(185, 32);
            this.buttonAfisare.TabIndex = 14;
            this.buttonAfisare.Text = "Afișare instrumente";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditare
            // 
            this.buttonEditare.Location = new System.Drawing.Point(446, 348);
            this.buttonEditare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditare.Name = "buttonEditare";
            this.buttonEditare.Size = new System.Drawing.Size(110, 34);
            this.buttonEditare.TabIndex = 15;
            this.buttonEditare.Text = "Actualizare";
            this.buttonEditare.UseVisualStyleBackColor = true;
            this.buttonEditare.Click += new System.EventHandler(this.buttonEditare_Click);
            // 
            // buttonStergere
            // 
            this.buttonStergere.Location = new System.Drawing.Point(564, 348);
            this.buttonStergere.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStergere.Name = "buttonStergere";
            this.buttonStergere.Size = new System.Drawing.Size(100, 34);
            this.buttonStergere.TabIndex = 16;
            this.buttonStergere.Text = "Ștergere";
            this.buttonStergere.UseVisualStyleBackColor = true;
            this.buttonStergere.Click += new System.EventHandler(this.buttonStergere_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(323, 395);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 19);
            this.labelStatus.TabIndex = 18;
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(361, 311);
            this.labelCantitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(63, 19);
            this.labelCantitate.TabIndex = 19;
            this.labelCantitate.Text = "Cantitate";
            // 
            // listBoxInstrumente
            // 
            this.listBoxInstrumente.FormattingEnabled = true;
            this.listBoxInstrumente.ItemHeight = 19;
            this.listBoxInstrumente.Location = new System.Drawing.Point(327, 470);
            this.listBoxInstrumente.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxInstrumente.Name = "listBoxInstrumente";
            this.listBoxInstrumente.Size = new System.Drawing.Size(755, 118);
            this.listBoxInstrumente.TabIndex = 21;
            this.listBoxInstrumente.SelectedIndexChanged += new System.EventHandler(this.listBoxInstrumente_SelectedIndexChanged);
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(682, 348);
            this.buttonCauta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(100, 34);
            this.buttonCauta.TabIndex = 17;
            this.buttonCauta.Text = "Căutare";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.button1_Cautare);
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(478, 304);
            this.textBoxCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(148, 26);
            this.textBoxCantitate.TabIndex = 22;
            // 
            // openFileDialogSterge
            // 
            this.openFileDialogSterge.FileName = "Șterge";
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(1196, 673);
            this.buttonInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(90, 27);
            this.buttonInapoi.TabIndex = 23;
            this.buttonInapoi.Text = "Înapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // labelAngajatConectat
            // 
            this.labelAngajatConectat.AutoSize = true;
            this.labelAngajatConectat.Location = new System.Drawing.Point(32, 33);
            this.labelAngajatConectat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngajatConectat.Name = "labelAngajatConectat";
            this.labelAngajatConectat.Size = new System.Drawing.Size(0, 19);
            this.labelAngajatConectat.TabIndex = 24;
            // 
            // FormAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 727);
            this.Controls.Add(this.labelAngajatConectat);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.listBoxInstrumente);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.buttonStergere);
            this.Controls.Add(this.buttonEditare);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.radioButtonSuflat);
            this.Controls.Add(this.radioButtonClape);
            this.Controls.Add(this.radioButtonCoarda);
            this.Controls.Add(this.radioButtonPercutie);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelInfoAdauga);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAngajat";
            this.Text = "FormAngajat";
            this.Load += new System.EventHandler(this.FormAngajat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoAdauga;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.RadioButton radioButtonCoarda;
        private System.Windows.Forms.RadioButton radioButtonClape;
        private System.Windows.Forms.RadioButton radioButtonSuflat;
        private System.Windows.Forms.RadioButton radioButtonPercutie;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxPret;
        //  private System.Windows.Forms.DateTimePicker dateTimePickerDataExpirarii;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Button buttonEditare;
        private System.Windows.Forms.Button buttonStergere;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.ListBox listBoxInstrumente;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.OpenFileDialog openFileDialogSterge;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Label labelAngajatConectat;
    }
}