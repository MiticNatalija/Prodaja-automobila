namespace Desktop
{
    partial class frmPredstavnistvo
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
            this.dgvPredstavnistvo = new System.Windows.Forms.DataGridView();
            this.btnIzmeniPredstavnistvo = new System.Windows.Forms.Button();
            this.btnObrisiPredstavnistvo = new System.Windows.Forms.Button();
            this.tabPrikaz = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPregledServisa = new System.Windows.Forms.Button();
            this.btnServisVozila = new System.Windows.Forms.Button();
            this.btnSalonAutomobili = new System.Windows.Forms.Button();
            this.btnPredstavnik = new System.Windows.Forms.Button();
            this.btnDodajPredstavnistvo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOceneMehanicara = new System.Windows.Forms.Button();
            this.btnObrisiRadnika = new System.Windows.Forms.Button();
            this.btnIzmeniRadnika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.dgvPredstavnik = new System.Windows.Forms.DataGridView();
            this.btnRadnaKnjizica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstavnistvo)).BeginInit();
            this.tabPrikaz.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstavnik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPredstavnistvo
            // 
            this.dgvPredstavnistvo.AllowUserToResizeRows = false;
            this.dgvPredstavnistvo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPredstavnistvo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPredstavnistvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredstavnistvo.Location = new System.Drawing.Point(0, 6);
            this.dgvPredstavnistvo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPredstavnistvo.MultiSelect = false;
            this.dgvPredstavnistvo.Name = "dgvPredstavnistvo";
            this.dgvPredstavnistvo.ReadOnly = true;
            this.dgvPredstavnistvo.RowTemplate.Height = 24;
            this.dgvPredstavnistvo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredstavnistvo.Size = new System.Drawing.Size(848, 603);
            this.dgvPredstavnistvo.TabIndex = 0;
            this.dgvPredstavnistvo.SelectionChanged += new System.EventHandler(this.dgvPredstavnistvo_SelectionChanged);
            // 
            // btnIzmeniPredstavnistvo
            // 
            this.btnIzmeniPredstavnistvo.Location = new System.Drawing.Point(932, 94);
            this.btnIzmeniPredstavnistvo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmeniPredstavnistvo.Name = "btnIzmeniPredstavnistvo";
            this.btnIzmeniPredstavnistvo.Size = new System.Drawing.Size(248, 54);
            this.btnIzmeniPredstavnistvo.TabIndex = 1;
            this.btnIzmeniPredstavnistvo.Text = "Izmeni predstavnistvo";
            this.btnIzmeniPredstavnistvo.UseVisualStyleBackColor = true;
            this.btnIzmeniPredstavnistvo.Click += new System.EventHandler(this.btnIzmeniPredstavnistvo_Click);
            // 
            // btnObrisiPredstavnistvo
            // 
            this.btnObrisiPredstavnistvo.Location = new System.Drawing.Point(932, 180);
            this.btnObrisiPredstavnistvo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiPredstavnistvo.Name = "btnObrisiPredstavnistvo";
            this.btnObrisiPredstavnistvo.Size = new System.Drawing.Size(248, 54);
            this.btnObrisiPredstavnistvo.TabIndex = 2;
            this.btnObrisiPredstavnistvo.Text = "Obrisi predstavnistvo";
            this.btnObrisiPredstavnistvo.UseVisualStyleBackColor = true;
            this.btnObrisiPredstavnistvo.Click += new System.EventHandler(this.btnObrisiPredstavnistvo_Click);
            // 
            // tabPrikaz
            // 
            this.tabPrikaz.Controls.Add(this.tabPage1);
            this.tabPrikaz.Controls.Add(this.tabPage2);
            this.tabPrikaz.Location = new System.Drawing.Point(16, 15);
            this.tabPrikaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPrikaz.Name = "tabPrikaz";
            this.tabPrikaz.SelectedIndex = 0;
            this.tabPrikaz.Size = new System.Drawing.Size(1347, 654);
            this.tabPrikaz.TabIndex = 1;
            this.tabPrikaz.SelectedIndexChanged += new System.EventHandler(this.tabPrikaz_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPregledServisa);
            this.tabPage1.Controls.Add(this.btnServisVozila);
            this.tabPage1.Controls.Add(this.btnSalonAutomobili);
            this.tabPage1.Controls.Add(this.btnPredstavnik);
            this.tabPage1.Controls.Add(this.btnIzmeniPredstavnistvo);
            this.tabPage1.Controls.Add(this.btnObrisiPredstavnistvo);
            this.tabPage1.Controls.Add(this.btnDodajPredstavnistvo);
            this.tabPage1.Controls.Add(this.dgvPredstavnistvo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1339, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Predstavnistva";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPregledServisa
            // 
            this.btnPregledServisa.Location = new System.Drawing.Point(932, 524);
            this.btnPregledServisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPregledServisa.Name = "btnPregledServisa";
            this.btnPregledServisa.Size = new System.Drawing.Size(248, 54);
            this.btnPregledServisa.TabIndex = 6;
            this.btnPregledServisa.Text = "Vidi servise";
            this.btnPregledServisa.UseVisualStyleBackColor = true;
            this.btnPregledServisa.Click += new System.EventHandler(this.btnPregledServisa_Click);
            // 
            // btnServisVozila
            // 
            this.btnServisVozila.Location = new System.Drawing.Point(932, 438);
            this.btnServisVozila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServisVozila.Name = "btnServisVozila";
            this.btnServisVozila.Size = new System.Drawing.Size(248, 54);
            this.btnServisVozila.TabIndex = 5;
            this.btnServisVozila.Text = "Servisiranje vozila u izabranom servisu";
            this.btnServisVozila.UseVisualStyleBackColor = true;
            this.btnServisVozila.Click += new System.EventHandler(this.btnServisVozila_Click);
            // 
            // btnSalonAutomobili
            // 
            this.btnSalonAutomobili.Location = new System.Drawing.Point(932, 352);
            this.btnSalonAutomobili.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalonAutomobili.Name = "btnSalonAutomobili";
            this.btnSalonAutomobili.Size = new System.Drawing.Size(248, 54);
            this.btnSalonAutomobili.TabIndex = 4;
            this.btnSalonAutomobili.Text = "Vozila izabranog salona";
            this.btnSalonAutomobili.UseVisualStyleBackColor = true;
            this.btnSalonAutomobili.Click += new System.EventHandler(this.btnSalonAutomobili_Click);
            // 
            // btnPredstavnik
            // 
            this.btnPredstavnik.Location = new System.Drawing.Point(932, 266);
            this.btnPredstavnik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPredstavnik.Name = "btnPredstavnik";
            this.btnPredstavnik.Size = new System.Drawing.Size(248, 54);
            this.btnPredstavnik.TabIndex = 3;
            this.btnPredstavnik.Text = "Predstavnici izabranog predstavnistva";
            this.btnPredstavnik.UseVisualStyleBackColor = true;
            this.btnPredstavnik.Click += new System.EventHandler(this.btnPredstavnik_Click);
            // 
            // btnDodajPredstavnistvo
            // 
            this.btnDodajPredstavnistvo.Location = new System.Drawing.Point(932, 7);
            this.btnDodajPredstavnistvo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajPredstavnistvo.Name = "btnDodajPredstavnistvo";
            this.btnDodajPredstavnistvo.Size = new System.Drawing.Size(248, 54);
            this.btnDodajPredstavnistvo.TabIndex = 1;
            this.btnDodajPredstavnistvo.Text = "Dodaj predstavnistvo";
            this.btnDodajPredstavnistvo.UseVisualStyleBackColor = true;
            this.btnDodajPredstavnistvo.Click += new System.EventHandler(this.btnDodajPredstavnistvo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRadnaKnjizica);
            this.tabPage2.Controls.Add(this.btnOceneMehanicara);
            this.tabPage2.Controls.Add(this.btnObrisiRadnika);
            this.tabPage2.Controls.Add(this.btnIzmeniRadnika);
            this.tabPage2.Controls.Add(this.btnDodajZaposlenog);
            this.tabPage2.Controls.Add(this.dgvPredstavnik);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1339, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zaposleni";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOceneMehanicara
            // 
            this.btnOceneMehanicara.Location = new System.Drawing.Point(1127, 268);
            this.btnOceneMehanicara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOceneMehanicara.Name = "btnOceneMehanicara";
            this.btnOceneMehanicara.Size = new System.Drawing.Size(184, 73);
            this.btnOceneMehanicara.TabIndex = 5;
            this.btnOceneMehanicara.Text = "Ocene mehanicara";
            this.btnOceneMehanicara.UseVisualStyleBackColor = true;
            this.btnOceneMehanicara.Click += new System.EventHandler(this.btnOceneMehanicara_Click);
            // 
            // btnObrisiRadnika
            // 
            this.btnObrisiRadnika.Location = new System.Drawing.Point(1127, 187);
            this.btnObrisiRadnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiRadnika.Name = "btnObrisiRadnika";
            this.btnObrisiRadnika.Size = new System.Drawing.Size(184, 73);
            this.btnObrisiRadnika.TabIndex = 4;
            this.btnObrisiRadnika.Text = "Obrisi radnika";
            this.btnObrisiRadnika.UseVisualStyleBackColor = true;
            this.btnObrisiRadnika.Click += new System.EventHandler(this.btnObrisiRadnika_Click);
            // 
            // btnIzmeniRadnika
            // 
            this.btnIzmeniRadnika.Location = new System.Drawing.Point(1127, 107);
            this.btnIzmeniRadnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmeniRadnika.Name = "btnIzmeniRadnika";
            this.btnIzmeniRadnika.Size = new System.Drawing.Size(184, 73);
            this.btnIzmeniRadnika.TabIndex = 3;
            this.btnIzmeniRadnika.Text = "Izmeni radnika";
            this.btnIzmeniRadnika.UseVisualStyleBackColor = true;
            this.btnIzmeniRadnika.Click += new System.EventHandler(this.btnIzmeniRadnika_Click);
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(1127, 28);
            this.btnDodajZaposlenog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(184, 73);
            this.btnDodajZaposlenog.TabIndex = 2;
            this.btnDodajZaposlenog.Text = "Dodaj radnika";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // dgvPredstavnik
            // 
            this.dgvPredstavnik.AllowUserToResizeRows = false;
            this.dgvPredstavnik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPredstavnik.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPredstavnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredstavnik.Location = new System.Drawing.Point(8, 7);
            this.dgvPredstavnik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPredstavnik.MultiSelect = false;
            this.dgvPredstavnik.Name = "dgvPredstavnik";
            this.dgvPredstavnik.ReadOnly = true;
            this.dgvPredstavnik.RowTemplate.Height = 24;
            this.dgvPredstavnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredstavnik.Size = new System.Drawing.Size(1093, 603);
            this.dgvPredstavnik.TabIndex = 1;
            this.dgvPredstavnik.SelectionChanged += new System.EventHandler(this.dgvPredstavnik_SelectionChanged);
            // 
            // btnRadnaKnjizica
            // 
            this.btnRadnaKnjizica.Location = new System.Drawing.Point(1127, 349);
            this.btnRadnaKnjizica.Margin = new System.Windows.Forms.Padding(4);
            this.btnRadnaKnjizica.Name = "btnRadnaKnjizica";
            this.btnRadnaKnjizica.Size = new System.Drawing.Size(184, 73);
            this.btnRadnaKnjizica.TabIndex = 6;
            this.btnRadnaKnjizica.Text = "Radna knjizica";
            this.btnRadnaKnjizica.UseVisualStyleBackColor = true;
            this.btnRadnaKnjizica.Click += new System.EventHandler(this.btnRadnaKnjizica_Click);
            // 
            // frmPredstavnistvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 665);
            this.Controls.Add(this.tabPrikaz);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmPredstavnistvo";
            this.Text = "Predstavnistvo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstavnistvo)).EndInit();
            this.tabPrikaz.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstavnik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPredstavnistvo;
        private System.Windows.Forms.Button btnIzmeniPredstavnistvo;
        private System.Windows.Forms.Button btnObrisiPredstavnistvo;
        private System.Windows.Forms.TabControl tabPrikaz;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDodajPredstavnistvo;
        private System.Windows.Forms.DataGridView dgvPredstavnik;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.Button btnPredstavnik;
        private System.Windows.Forms.Button btnSalonAutomobili;
        private System.Windows.Forms.Button btnIzmeniRadnika;
        private System.Windows.Forms.Button btnObrisiRadnika;
        private System.Windows.Forms.Button btnServisVozila;
        private System.Windows.Forms.Button btnPregledServisa;
        private System.Windows.Forms.Button btnOceneMehanicara;
        private System.Windows.Forms.Button btnRadnaKnjizica;
    }
}