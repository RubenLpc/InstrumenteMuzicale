namespace InterfataUtilizator_WindowsForms
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.buttonAngajat = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonAngajatNou = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.textBoxEmailNume = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonConectare = new System.Windows.Forms.Button();
            this.labelParolaUitata = new System.Windows.Forms.Label();
            this.labelCredentialeStatus = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxCodAcces = new System.Windows.Forms.TextBox();
            this.textBoxContNouEmail = new System.Windows.Forms.TextBox();
            this.textBoxContNouNume = new System.Windows.Forms.TextBox();
            this.textBoxContNouParola = new System.Windows.Forms.TextBox();
            this.labelContNouEmail = new System.Windows.Forms.Label();
            this.labelContNouNume = new System.Windows.Forms.Label();
            this.labelContNouParola = new System.Windows.Forms.Label();
            this.buttonAdaugaAngajat = new System.Windows.Forms.Button();
            this.labelEmailNume = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.buttonAflaParola = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAngajat
            // 
            this.buttonAngajat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAngajat.Location = new System.Drawing.Point(844, 312);
            this.buttonAngajat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAngajat.Name = "buttonAngajat";
            this.buttonAngajat.Size = new System.Drawing.Size(181, 61);
            this.buttonAngajat.TabIndex = 0;
            this.buttonAngajat.Text = "ANGAJAT";
            this.buttonAngajat.UseVisualStyleBackColor = false;
            this.buttonAngajat.Click += new System.EventHandler(this.buttonAngajat_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(405, 312);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(181, 65);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "CLIENT";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonAngajatNou
            // 
            this.buttonAngajatNou.Location = new System.Drawing.Point(627, 340);
            this.buttonAngajatNou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAngajatNou.Name = "buttonAngajatNou";
            this.buttonAngajatNou.Size = new System.Drawing.Size(190, 33);
            this.buttonAngajatNou.TabIndex = 2;
            this.buttonAngajatNou.Text = "Doriți să creați un cont nou?";
            this.buttonAngajatNou.UseVisualStyleBackColor = true;
            this.buttonAngajatNou.Click += new System.EventHandler(this.buttonAngajatNou_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Location = new System.Drawing.Point(633, 312);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(181, 61);
            this.buttonIesire.TabIndex = 3;
            this.buttonIesire.Text = "EXIT";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // textBoxEmailNume
            // 
            this.textBoxEmailNume.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmailNume.Location = new System.Drawing.Point(616, 182);
            this.textBoxEmailNume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmailNume.Name = "textBoxEmailNume";
            this.textBoxEmailNume.Size = new System.Drawing.Size(211, 26);
            this.textBoxEmailNume.TabIndex = 4;
            this.textBoxEmailNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxParola.ForeColor = System.Drawing.Color.Black;
            this.textBoxParola.Location = new System.Drawing.Point(616, 222);
            this.textBoxParola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(211, 26);
            this.textBoxParola.TabIndex = 5;
            this.textBoxParola.TextChanged += new System.EventHandler(this.textBoxParola_TextChanged);
            // 
            // buttonConectare
            // 
            this.buttonConectare.Location = new System.Drawing.Point(616, 278);
            this.buttonConectare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConectare.Name = "buttonConectare";
            this.buttonConectare.Size = new System.Drawing.Size(211, 33);
            this.buttonConectare.TabIndex = 6;
            this.buttonConectare.Text = "Conectează-te";
            this.buttonConectare.UseVisualStyleBackColor = true;
            this.buttonConectare.Click += new System.EventHandler(this.buttonConectare_Click);
            // 
            // labelParolaUitata
            // 
            this.labelParolaUitata.AutoSize = true;
            this.labelParolaUitata.Location = new System.Drawing.Point(671, 316);
            this.labelParolaUitata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParolaUitata.Name = "labelParolaUitata";
            this.labelParolaUitata.Size = new System.Drawing.Size(105, 19);
            this.labelParolaUitata.TabIndex = 7;
            this.labelParolaUitata.Text = "Ați uitat parola?";
            this.labelParolaUitata.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCredentialeStatus
            // 
            this.labelCredentialeStatus.AutoSize = true;
            this.labelCredentialeStatus.ForeColor = System.Drawing.Color.Red;
            this.labelCredentialeStatus.Location = new System.Drawing.Point(622, 254);
            this.labelCredentialeStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCredentialeStatus.Name = "labelCredentialeStatus";
            this.labelCredentialeStatus.Size = new System.Drawing.Size(0, 19);
            this.labelCredentialeStatus.TabIndex = 8;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(512, 378);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(391, 19);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Pentru a crea un cont nou trebuie să introduceți codul de acces!";
            this.labelStatus.Click += new System.EventHandler(this.labelCreazaStatus_Click);
            // 
            // textBoxCodAcces
            // 
            this.textBoxCodAcces.Location = new System.Drawing.Point(633, 402);
            this.textBoxCodAcces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCodAcces.Name = "textBoxCodAcces";
            this.textBoxCodAcces.Size = new System.Drawing.Size(148, 26);
            this.textBoxCodAcces.TabIndex = 10;
            this.textBoxCodAcces.TextChanged += new System.EventHandler(this.textBoxCodAcces_TextChanged);
            // 
            // textBoxContNouEmail
            // 
            this.textBoxContNouEmail.Location = new System.Drawing.Point(633, 440);
            this.textBoxContNouEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContNouEmail.Name = "textBoxContNouEmail";
            this.textBoxContNouEmail.Size = new System.Drawing.Size(148, 26);
            this.textBoxContNouEmail.TabIndex = 11;
            this.textBoxContNouEmail.TextChanged += new System.EventHandler(this.textBoxContNouEmail_TextChanged);
            // 
            // textBoxContNouNume
            // 
            this.textBoxContNouNume.Location = new System.Drawing.Point(633, 478);
            this.textBoxContNouNume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContNouNume.Name = "textBoxContNouNume";
            this.textBoxContNouNume.Size = new System.Drawing.Size(148, 26);
            this.textBoxContNouNume.TabIndex = 12;
            this.textBoxContNouNume.TextChanged += new System.EventHandler(this.textBoxContNouNume_TextChanged);
            // 
            // textBoxContNouParola
            // 
            this.textBoxContNouParola.Location = new System.Drawing.Point(633, 516);
            this.textBoxContNouParola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContNouParola.Name = "textBoxContNouParola";
            this.textBoxContNouParola.Size = new System.Drawing.Size(148, 26);
            this.textBoxContNouParola.TabIndex = 13;
            this.textBoxContNouParola.TextChanged += new System.EventHandler(this.textBoxContNouParola_TextChanged);
            // 
            // labelContNouEmail
            // 
            this.labelContNouEmail.AutoSize = true;
            this.labelContNouEmail.Location = new System.Drawing.Point(538, 445);
            this.labelContNouEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContNouEmail.Name = "labelContNouEmail";
            this.labelContNouEmail.Size = new System.Drawing.Size(48, 19);
            this.labelContNouEmail.TabIndex = 14;
            this.labelContNouEmail.Text = "E-mail";
            // 
            // labelContNouNume
            // 
            this.labelContNouNume.AutoSize = true;
            this.labelContNouNume.Location = new System.Drawing.Point(538, 483);
            this.labelContNouNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContNouNume.Name = "labelContNouNume";
            this.labelContNouNume.Size = new System.Drawing.Size(46, 19);
            this.labelContNouNume.TabIndex = 15;
            this.labelContNouNume.Text = "Nume";
            // 
            // labelContNouParola
            // 
            this.labelContNouParola.AutoSize = true;
            this.labelContNouParola.Location = new System.Drawing.Point(540, 519);
            this.labelContNouParola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContNouParola.Name = "labelContNouParola";
            this.labelContNouParola.Size = new System.Drawing.Size(48, 19);
            this.labelContNouParola.TabIndex = 16;
            this.labelContNouParola.Text = "Parolă";
            // 
            // buttonAdaugaAngajat
            // 
            this.buttonAdaugaAngajat.Location = new System.Drawing.Point(516, 572);
            this.buttonAdaugaAngajat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdaugaAngajat.Name = "buttonAdaugaAngajat";
            this.buttonAdaugaAngajat.Size = new System.Drawing.Size(112, 33);
            this.buttonAdaugaAngajat.TabIndex = 17;
            this.buttonAdaugaAngajat.Text = "Creați";
            this.buttonAdaugaAngajat.UseVisualStyleBackColor = true;
            this.buttonAdaugaAngajat.Click += new System.EventHandler(this.buttonAdaugaAngajat_Click);
            // 
            // labelEmailNume
            // 
            this.labelEmailNume.AutoSize = true;
            this.labelEmailNume.Location = new System.Drawing.Point(512, 182);
            this.labelEmailNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailNume.Name = "labelEmailNume";
            this.labelEmailNume.Size = new System.Drawing.Size(84, 19);
            this.labelEmailNume.TabIndex = 20;
            this.labelEmailNume.Text = "E-mail/nume";
            this.labelEmailNume.Click += new System.EventHandler(this.labelEmailNume_Click);
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(512, 222);
            this.labelParola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(48, 19);
            this.labelParola.TabIndex = 21;
            this.labelParola.Text = "Parolă";
            // 
            // buttonAflaParola
            // 
            this.buttonAflaParola.Location = new System.Drawing.Point(516, 572);
            this.buttonAflaParola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAflaParola.Name = "buttonAflaParola";
            this.buttonAflaParola.Size = new System.Drawing.Size(112, 33);
            this.buttonAflaParola.TabIndex = 22;
            this.buttonAflaParola.Text = "Info";
            this.buttonAflaParola.UseVisualStyleBackColor = true;
            this.buttonAflaParola.Click += new System.EventHandler(this.buttonAflaParola_Click);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(1179, 700);
            this.buttonInapoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(112, 33);
            this.buttonInapoi.TabIndex = 23;
            this.buttonInapoi.Text = "Înapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1325, 772);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonAngajat);
            this.Controls.Add(this.buttonAflaParola);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelEmailNume);
            this.Controls.Add(this.buttonAdaugaAngajat);
            this.Controls.Add(this.labelContNouParola);
            this.Controls.Add(this.labelContNouNume);
            this.Controls.Add(this.labelContNouEmail);
            this.Controls.Add(this.textBoxContNouParola);
            this.Controls.Add(this.textBoxContNouNume);
            this.Controls.Add(this.textBoxContNouEmail);
            this.Controls.Add(this.textBoxCodAcces);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCredentialeStatus);
            this.Controls.Add(this.labelParolaUitata);
            this.Controls.Add(this.buttonConectare);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxEmailNume);
            this.Controls.Add(this.buttonAngajatNou);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAngajat;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonAngajatNou;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.TextBox textBoxEmailNume;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button buttonConectare;
        private System.Windows.Forms.Label labelParolaUitata;
        private System.Windows.Forms.Label labelCredentialeStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxCodAcces;
        private System.Windows.Forms.TextBox textBoxContNouEmail;
        private System.Windows.Forms.TextBox textBoxContNouNume;
        private System.Windows.Forms.TextBox textBoxContNouParola;
        private System.Windows.Forms.Label labelContNouEmail;
        private System.Windows.Forms.Label labelContNouNume;
        private System.Windows.Forms.Label labelContNouParola;
        private System.Windows.Forms.Button buttonAdaugaAngajat;
        private System.Windows.Forms.Label labelEmailNume;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Button buttonAflaParola;
        private System.Windows.Forms.Button buttonInapoi;
    }
}