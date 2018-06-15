namespace Desktop
{
    partial class IzmeniZaposlenog
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
            this.btn = new System.Windows.Forms.Button();
            this.dtpZaposlenje = new System.Windows.Forms.DateTimePicker();
            this.dtpRodjenje = new System.Windows.Forms.DateTimePicker();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtSpecijalnost = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMbr = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtImeOca = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(195, 239);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 41;
            this.btn.Text = "OK";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dtpZaposlenje
            // 
            this.dtpZaposlenje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpZaposlenje.Location = new System.Drawing.Point(111, 161);
            this.dtpZaposlenje.Name = "dtpZaposlenje";
            this.dtpZaposlenje.Size = new System.Drawing.Size(89, 20);
            this.dtpZaposlenje.TabIndex = 39;
            this.dtpZaposlenje.ValueChanged += new System.EventHandler(this.dtpZaposlenje_ValueChanged);
            // 
            // dtpRodjenje
            // 
            this.dtpRodjenje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRodjenje.Location = new System.Drawing.Point(111, 135);
            this.dtpRodjenje.Name = "dtpRodjenje";
            this.dtpRodjenje.Size = new System.Drawing.Size(89, 20);
            this.dtpRodjenje.TabIndex = 38;
            this.dtpRodjenje.ValueChanged += new System.EventHandler(this.dtpRodjenje_ValueChanged);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(322, 66);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 37;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            this.txtAdresa.Leave += new System.EventHandler(this.txtAdresa_Leave);
            // 
            // txtSpecijalnost
            // 
            this.txtSpecijalnost.Location = new System.Drawing.Point(322, 12);
            this.txtSpecijalnost.Name = "txtSpecijalnost";
            this.txtSpecijalnost.Size = new System.Drawing.Size(100, 20);
            this.txtSpecijalnost.TabIndex = 36;
            this.txtSpecijalnost.TextChanged += new System.EventHandler(this.txtSpecijalnost_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(322, 101);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 35;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtMbr
            // 
            this.txtMbr.Location = new System.Drawing.Point(100, 99);
            this.txtMbr.MaxLength = 13;
            this.txtMbr.Name = "txtMbr";
            this.txtMbr.Size = new System.Drawing.Size(100, 20);
            this.txtMbr.TabIndex = 34;
            this.txtMbr.TextChanged += new System.EventHandler(this.txtMbr_TextChanged);
            this.txtMbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMbr_KeyPress);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(100, 73);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 33;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtImeOca
            // 
            this.txtImeOca.Location = new System.Drawing.Point(100, 42);
            this.txtImeOca.Name = "txtImeOca";
            this.txtImeOca.Size = new System.Drawing.Size(100, 20);
            this.txtImeOca.TabIndex = 32;
            this.txtImeOca.TextChanged += new System.EventHandler(this.txtImeOca_TextChanged);
            this.txtImeOca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImeOca_KeyPress);
            this.txtImeOca.Leave += new System.EventHandler(this.txtImeOca_Leave);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(100, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 31;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Adresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Specijalnost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Datum zaposlenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Datum rodjenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "JMBG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ime oca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ime";
            // 
            // IzmeniZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 299);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dtpZaposlenje);
            this.Controls.Add(this.dtpRodjenje);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtSpecijalnost);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMbr);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtImeOca);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IzmeniZaposlenog";
            this.Text = "IzmeniZaposlenog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DateTimePicker dtpZaposlenje;
        private System.Windows.Forms.DateTimePicker dtpRodjenje;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtSpecijalnost;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMbr;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtImeOca;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}