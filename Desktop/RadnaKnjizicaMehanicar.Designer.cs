namespace Desktop
{
    partial class RadnaKnjizicaMehanicar
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
            this.dgvRadnaKnjizica = new System.Windows.Forms.DataGridView();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnZavrsiRadniOdnos = new System.Windows.Forms.Button();
            this.btnAngazuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnaKnjizica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRadnaKnjizica
            // 
            this.dgvRadnaKnjizica.AllowUserToResizeRows = false;
            this.dgvRadnaKnjizica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRadnaKnjizica.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRadnaKnjizica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnaKnjizica.Location = new System.Drawing.Point(13, 78);
            this.dgvRadnaKnjizica.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRadnaKnjizica.MultiSelect = false;
            this.dgvRadnaKnjizica.Name = "dgvRadnaKnjizica";
            this.dgvRadnaKnjizica.ReadOnly = true;
            this.dgvRadnaKnjizica.RowTemplate.Height = 24;
            this.dgvRadnaKnjizica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnaKnjizica.Size = new System.Drawing.Size(689, 313);
            this.dgvRadnaKnjizica.TabIndex = 2;
            this.dgvRadnaKnjizica.SelectionChanged += new System.EventHandler(this.dgvRadnaKnjizica_SelectionChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(59, 31);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(449, 31);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(246, 31);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(50, 17);
            this.lblJmbg.TabIndex = 5;
            this.lblJmbg.Text = "JMBG:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(99, 28);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(141, 22);
            this.txtIme.TabIndex = 6;
            // 
            // txtJmbg
            // 
            this.txtJmbg.Location = new System.Drawing.Point(302, 28);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.ReadOnly = true;
            this.txtJmbg.Size = new System.Drawing.Size(141, 22);
            this.txtJmbg.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(518, 28);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(141, 22);
            this.txtPrezime.TabIndex = 8;
            // 
            // btnZavrsiRadniOdnos
            // 
            this.btnZavrsiRadniOdnos.Enabled = false;
            this.btnZavrsiRadniOdnos.Location = new System.Drawing.Point(62, 421);
            this.btnZavrsiRadniOdnos.Name = "btnZavrsiRadniOdnos";
            this.btnZavrsiRadniOdnos.Size = new System.Drawing.Size(158, 59);
            this.btnZavrsiRadniOdnos.TabIndex = 9;
            this.btnZavrsiRadniOdnos.Text = "Zavrsi radni odnos i oceni";
            this.btnZavrsiRadniOdnos.UseVisualStyleBackColor = true;
            this.btnZavrsiRadniOdnos.Click += new System.EventHandler(this.btnZavrsiRadniOdnos_Click);
            // 
            // btnAngazuj
            // 
            this.btnAngazuj.Enabled = false;
            this.btnAngazuj.Location = new System.Drawing.Point(501, 421);
            this.btnAngazuj.Name = "btnAngazuj";
            this.btnAngazuj.Size = new System.Drawing.Size(158, 59);
            this.btnAngazuj.TabIndex = 10;
            this.btnAngazuj.Text = "Angazuj mehanicara u servis";
            this.btnAngazuj.UseVisualStyleBackColor = true;
            this.btnAngazuj.Click += new System.EventHandler(this.btnAngazuj_Click);
            // 
            // RadnaKnjizicaMehanicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 507);
            this.Controls.Add(this.btnAngazuj);
            this.Controls.Add(this.btnZavrsiRadniOdnos);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtJmbg);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dgvRadnaKnjizica);
            this.MaximumSize = new System.Drawing.Size(733, 554);
            this.MinimumSize = new System.Drawing.Size(733, 554);
            this.Name = "RadnaKnjizicaMehanicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radna knjizica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnaKnjizica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRadnaKnjizica;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnZavrsiRadniOdnos;
        private System.Windows.Forms.Button btnAngazuj;
    }
}