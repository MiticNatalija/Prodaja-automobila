namespace Desktop
{
    partial class frmServisVozila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtCenaUsluge = new System.Windows.Forms.TextBox();
            this.txtTelefonVlasnika = new System.Windows.Forms.TextBox();
            this.txtAdresaVlasnika = new System.Windows.Forms.TextBox();
            this.dtpDatumIntervencije = new System.Windows.Forms.DateTimePicker();
            this.txtRadovi = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajMehanicara = new System.Windows.Forms.Button();
            this.dgvMehanicari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMehanicari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registarski broj vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum intervencije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radovi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena usluge:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon vlasnika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresa vlasnika:";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(142, 34);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(107, 20);
            this.txtRegistracija.TabIndex = 6;
            // 
            // txtCenaUsluge
            // 
            this.txtCenaUsluge.Location = new System.Drawing.Point(142, 376);
            this.txtCenaUsluge.Name = "txtCenaUsluge";
            this.txtCenaUsluge.Size = new System.Drawing.Size(108, 20);
            this.txtCenaUsluge.TabIndex = 7;
            // 
            // txtTelefonVlasnika
            // 
            this.txtTelefonVlasnika.Location = new System.Drawing.Point(142, 420);
            this.txtTelefonVlasnika.Name = "txtTelefonVlasnika";
            this.txtTelefonVlasnika.Size = new System.Drawing.Size(108, 20);
            this.txtTelefonVlasnika.TabIndex = 8;
            // 
            // txtAdresaVlasnika
            // 
            this.txtAdresaVlasnika.Location = new System.Drawing.Point(142, 452);
            this.txtAdresaVlasnika.Name = "txtAdresaVlasnika";
            this.txtAdresaVlasnika.Size = new System.Drawing.Size(108, 20);
            this.txtAdresaVlasnika.TabIndex = 9;
            // 
            // dtpDatumIntervencije
            // 
            this.dtpDatumIntervencije.CustomFormat = "";
            this.dtpDatumIntervencije.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumIntervencije.Location = new System.Drawing.Point(142, 72);
            this.dtpDatumIntervencije.Name = "dtpDatumIntervencije";
            this.dtpDatumIntervencije.Size = new System.Drawing.Size(106, 20);
            this.dtpDatumIntervencije.TabIndex = 10;
            // 
            // txtRadovi
            // 
            this.txtRadovi.Location = new System.Drawing.Point(81, 114);
            this.txtRadovi.Multiline = true;
            this.txtRadovi.Name = "txtRadovi";
            this.txtRadovi.Size = new System.Drawing.Size(169, 68);
            this.txtRadovi.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(142, 487);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 30);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mehanicari koji rade u izabranom servisu:";
            // 
            // btnDodajMehanicara
            // 
            this.btnDodajMehanicara.Location = new System.Drawing.Point(142, 326);
            this.btnDodajMehanicara.Name = "btnDodajMehanicara";
            this.btnDodajMehanicara.Size = new System.Drawing.Size(108, 23);
            this.btnDodajMehanicara.TabIndex = 15;
            this.btnDodajMehanicara.Text = "Dodaj mehanicara";
            this.btnDodajMehanicara.UseVisualStyleBackColor = true;
            this.btnDodajMehanicara.Click += new System.EventHandler(this.btnDodajMehanicara_Click);
            // 
            // dgvMehanicari
            // 
            this.dgvMehanicari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMehanicari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMehanicari.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMehanicari.Location = new System.Drawing.Point(24, 216);
            this.dgvMehanicari.Name = "dgvMehanicari";
            this.dgvMehanicari.Size = new System.Drawing.Size(226, 104);
            this.dgvMehanicari.TabIndex = 16;
            // 
            // frmServisVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 520);
            this.Controls.Add(this.dgvMehanicari);
            this.Controls.Add(this.btnDodajMehanicara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRadovi);
            this.Controls.Add(this.dtpDatumIntervencije);
            this.Controls.Add(this.txtAdresaVlasnika);
            this.Controls.Add(this.txtTelefonVlasnika);
            this.Controls.Add(this.txtCenaUsluge);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmServisVozila";
            this.Text = "Servis vozila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMehanicari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtCenaUsluge;
        private System.Windows.Forms.TextBox txtTelefonVlasnika;
        private System.Windows.Forms.TextBox txtAdresaVlasnika;
        private System.Windows.Forms.DateTimePicker dtpDatumIntervencije;
        private System.Windows.Forms.TextBox txtRadovi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajMehanicara;
        private System.Windows.Forms.DataGridView dgvMehanicari;
    }
}