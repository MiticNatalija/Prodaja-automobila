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
            this.dgvPredstavnistvo.Location = new System.Drawing.Point(6, 6);
            this.dgvPredstavnistvo.MultiSelect = false;
            this.dgvPredstavnistvo.Name = "dgvPredstavnistvo";
            this.dgvPredstavnistvo.ReadOnly = true;
            this.dgvPredstavnistvo.RowTemplate.Height = 24;
            this.dgvPredstavnistvo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredstavnistvo.Size = new System.Drawing.Size(636, 490);
            this.dgvPredstavnistvo.TabIndex = 0;
            // 
            // tabPrikaz
            // 
            this.tabPrikaz.Controls.Add(this.tabPage1);
            this.tabPrikaz.Controls.Add(this.tabPage2);
            this.tabPrikaz.Location = new System.Drawing.Point(12, 12);
            this.tabPrikaz.Name = "tabPrikaz";
            this.tabPrikaz.SelectedIndex = 0;
            this.tabPrikaz.Size = new System.Drawing.Size(939, 531);
            this.tabPrikaz.TabIndex = 1;
            this.tabPrikaz.SelectedIndexChanged += new System.EventHandler(this.tabPrikaz_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDodajPredstavnistvo);
            this.tabPage1.Controls.Add(this.dgvPredstavnistvo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(931, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Predstavnistva";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDodajPredstavnistvo
            // 
            this.btnDodajPredstavnistvo.Location = new System.Drawing.Point(699, 6);
            this.btnDodajPredstavnistvo.Name = "btnDodajPredstavnistvo";
            this.btnDodajPredstavnistvo.Size = new System.Drawing.Size(186, 65);
            this.btnDodajPredstavnistvo.TabIndex = 1;
            this.btnDodajPredstavnistvo.Text = "Dodaj predstavnistvo";
            this.btnDodajPredstavnistvo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPredstavnik);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(931, 502);
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
            this.dgvPredstavnik.Location = new System.Drawing.Point(6, 6);
            this.dgvPredstavnik.MultiSelect = false;
            this.dgvPredstavnik.Name = "dgvPredstavnik";
            this.dgvPredstavnik.ReadOnly = true;
            this.dgvPredstavnik.RowTemplate.Height = 24;
            this.dgvPredstavnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredstavnik.Size = new System.Drawing.Size(820, 490);
            this.dgvPredstavnik.TabIndex = 1;
            // 
            // frmPredstavnistvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 555);
            this.Controls.Add(this.tabPrikaz);
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
        private System.Windows.Forms.TabControl tabPrikaz;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDodajPredstavnistvo;
        private System.Windows.Forms.DataGridView dgvPredstavnik;
    }
}