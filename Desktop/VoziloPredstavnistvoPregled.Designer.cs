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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
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
            this.dgvAutomobili.Size = new System.Drawing.Size(473, 405);
            this.dgvAutomobili.TabIndex = 1;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(529, 44);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(148, 49);
            this.btnDodajVozilo.TabIndex = 2;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnIzmeniVozilo
            // 
            this.btnIzmeniVozilo.Location = new System.Drawing.Point(529, 122);
            this.btnIzmeniVozilo.Name = "btnIzmeniVozilo";
            this.btnIzmeniVozilo.Size = new System.Drawing.Size(148, 49);
            this.btnIzmeniVozilo.TabIndex = 3;
            this.btnIzmeniVozilo.Text = "Izmeni vozilo";
            this.btnIzmeniVozilo.UseVisualStyleBackColor = true;
            this.btnIzmeniVozilo.Click += new System.EventHandler(this.btnIzmeniVozilo_Click);
            // 
            // btnIzbrisiVozilo
            // 
            this.btnIzbrisiVozilo.Location = new System.Drawing.Point(529, 199);
            this.btnIzbrisiVozilo.Name = "btnIzbrisiVozilo";
            this.btnIzbrisiVozilo.Size = new System.Drawing.Size(148, 49);
            this.btnIzbrisiVozilo.TabIndex = 4;
            this.btnIzbrisiVozilo.Text = "Obrisi vozilo";
            this.btnIzbrisiVozilo.UseVisualStyleBackColor = true;
            this.btnIzbrisiVozilo.Click += new System.EventHandler(this.btnIzbrisiVozilo_Click);
            // 
            // btnProdajVozilo
            // 
            this.btnProdajVozilo.Location = new System.Drawing.Point(529, 281);
            this.btnProdajVozilo.Name = "btnProdajVozilo";
            this.btnProdajVozilo.Size = new System.Drawing.Size(148, 49);
            this.btnProdajVozilo.TabIndex = 5;
            this.btnProdajVozilo.Text = "Prodaj vozilo";
            this.btnProdajVozilo.UseVisualStyleBackColor = true;
            this.btnProdajVozilo.Click += new System.EventHandler(this.btnProdajVozilo_Click);
            // 
            // VoziloPredstavnistvoPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 422);
            this.Controls.Add(this.btnProdajVozilo);
            this.Controls.Add(this.btnIzbrisiVozilo);
            this.Controls.Add(this.btnIzmeniVozilo);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.dgvAutomobili);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VoziloPredstavnistvoPregled";
            this.Text = "Vozilo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnIzmeniVozilo;
        private System.Windows.Forms.Button btnIzbrisiVozilo;
        private System.Windows.Forms.Button btnProdajVozilo;
    }
}