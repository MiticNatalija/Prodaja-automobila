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
            this.btnDodajPredstavnistvo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPredstavnik = new System.Windows.Forms.DataGridView();
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
            // 
            // btnIzmeniPredstavnistvo
            // 
            this.btnIzmeniPredstavnistvo.Location = new System.Drawing.Point(932, 110);
            this.btnIzmeniPredstavnistvo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmeniPredstavnistvo.Name = "btnIzmeniPredstavnistvo";
            this.btnIzmeniPredstavnistvo.Size = new System.Drawing.Size(248, 79);
            this.btnIzmeniPredstavnistvo.TabIndex = 1;
            this.btnIzmeniPredstavnistvo.Text = "Izmeni predstavnistvo";
            this.btnIzmeniPredstavnistvo.UseVisualStyleBackColor = true;
            this.btnIzmeniPredstavnistvo.Click += new System.EventHandler(btnIzmeniPredstavnistvo_Click);
            // 
            // btnObrisiPredstavnistvo
            // 
            this.btnObrisiPredstavnistvo.Location = new System.Drawing.Point(932, 213);
            this.btnObrisiPredstavnistvo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiPredstavnistvo.Name = "btnObrisiPredstavnistvo";
            this.btnObrisiPredstavnistvo.Size = new System.Drawing.Size(248, 79);
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
            this.tabPrikaz.Size = new System.Drawing.Size(1252, 654);
            this.tabPrikaz.TabIndex = 1;
            this.tabPrikaz.SelectedIndexChanged += new System.EventHandler(this.tabPrikaz_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnIzmeniPredstavnistvo);
            this.tabPage1.Controls.Add(this.btnObrisiPredstavnistvo);
            this.tabPage1.Controls.Add(this.btnDodajPredstavnistvo);
            this.tabPage1.Controls.Add(this.dgvPredstavnistvo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1244, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Predstavnistva";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDodajPredstavnistvo
            // 
            this.btnDodajPredstavnistvo.Location = new System.Drawing.Point(932, 7);
            this.btnDodajPredstavnistvo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajPredstavnistvo.Name = "btnDodajPredstavnistvo";
            this.btnDodajPredstavnistvo.Size = new System.Drawing.Size(248, 80);
            this.btnDodajPredstavnistvo.TabIndex = 1;
            this.btnDodajPredstavnistvo.Text = "Dodaj predstavnistvo";
            this.btnDodajPredstavnistvo.UseVisualStyleBackColor = true;
            this.btnDodajPredstavnistvo.Click += new System.EventHandler(this.btnDodajPredstavnistvo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPredstavnik);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1244, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zaposleni";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // 
            // frmPredstavnistvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 683);
            this.Controls.Add(this.tabPrikaz);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}