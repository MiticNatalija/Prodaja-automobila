namespace Desktop
{
    partial class VoziloPredstavnistvoPregled
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
            this.dgvAutomobili = new System.Windows.Forms.DataGridView();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnIzmeniVozilo = new System.Windows.Forms.Button();
            this.btnIzbrisiVozilo = new System.Windows.Forms.Button();
            this.btnProdajVozilo = new System.Windows.Forms.Button();
            this.dgvProdataVozila = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdataVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.AllowUserToResizeRows = false;
            this.dgvAutomobili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutomobili.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.Location = new System.Drawing.Point(9, 9);
            this.dgvAutomobili.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAutomobili.MultiSelect = false;
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.ReadOnly = true;
            this.dgvAutomobili.RowTemplate.Height = 24;
            this.dgvAutomobili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomobili.Size = new System.Drawing.Size(473, 295);
            this.dgvAutomobili.TabIndex = 1;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(529, 25);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(148, 49);
            this.btnDodajVozilo.TabIndex = 2;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnIzmeniVozilo
            // 
            this.btnIzmeniVozilo.Location = new System.Drawing.Point(529, 102);
            this.btnIzmeniVozilo.Name = "btnIzmeniVozilo";
            this.btnIzmeniVozilo.Size = new System.Drawing.Size(148, 49);
            this.btnIzmeniVozilo.TabIndex = 3;
            this.btnIzmeniVozilo.Text = "Izmeni vozilo";
            this.btnIzmeniVozilo.UseVisualStyleBackColor = true;
            this.btnIzmeniVozilo.Click += new System.EventHandler(this.btnIzmeniVozilo_Click);
            // 
            // btnIzbrisiVozilo
            // 
            this.btnIzbrisiVozilo.Location = new System.Drawing.Point(529, 176);
            this.btnIzbrisiVozilo.Name = "btnIzbrisiVozilo";
            this.btnIzbrisiVozilo.Size = new System.Drawing.Size(148, 49);
            this.btnIzbrisiVozilo.TabIndex = 4;
            this.btnIzbrisiVozilo.Text = "Obrisi vozilo";
            this.btnIzbrisiVozilo.UseVisualStyleBackColor = true;
            this.btnIzbrisiVozilo.Click += new System.EventHandler(this.btnIzbrisiVozilo_Click);
            // 
            // btnProdajVozilo
            // 
            this.btnProdajVozilo.Location = new System.Drawing.Point(529, 255);
            this.btnProdajVozilo.Name = "btnProdajVozilo";
            this.btnProdajVozilo.Size = new System.Drawing.Size(148, 49);
            this.btnProdajVozilo.TabIndex = 5;
            this.btnProdajVozilo.Text = "Prodaj vozilo";
            this.btnProdajVozilo.UseVisualStyleBackColor = true;
            this.btnProdajVozilo.Click += new System.EventHandler(this.btnProdajVozilo_Click);
            // 
            // dgvProdataVozila
            // 
            this.dgvProdataVozila.AllowUserToAddRows = false;
            this.dgvProdataVozila.AllowUserToDeleteRows = false;
            this.dgvProdataVozila.AllowUserToResizeColumns = false;
            this.dgvProdataVozila.AllowUserToResizeRows = false;
            this.dgvProdataVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdataVozila.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProdataVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdataVozila.Location = new System.Drawing.Point(12, 358);
            this.dgvProdataVozila.MultiSelect = false;
            this.dgvProdataVozila.Name = "dgvProdataVozila";
            this.dgvProdataVozila.ReadOnly = true;
            this.dgvProdataVozila.RowHeadersVisible = false;
            this.dgvProdataVozila.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProdataVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdataVozila.Size = new System.Drawing.Size(470, 192);
            this.dgvProdataVozila.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prodata vozia";
            // 
            // VoziloPredstavnistvoPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProdataVozila);
            this.Controls.Add(this.btnProdajVozilo);
            this.Controls.Add(this.btnIzbrisiVozilo);
            this.Controls.Add(this.btnIzmeniVozilo);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.dgvAutomobili);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VoziloPredstavnistvoPregled";
            this.Text = "Vozilo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdataVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnIzmeniVozilo;
        private System.Windows.Forms.Button btnIzbrisiVozilo;
        private System.Windows.Forms.Button btnProdajVozilo;
        private System.Windows.Forms.DataGridView dgvProdataVozila;
        private System.Windows.Forms.Label label1;
    }
}