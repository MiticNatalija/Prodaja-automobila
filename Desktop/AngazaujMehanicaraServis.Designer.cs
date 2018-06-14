namespace Desktop
{
    partial class AngazaujMehanicaraServis
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
            this.lblServis = new System.Windows.Forms.Label();
            this.lblDatumPocetakRada = new System.Windows.Forms.Label();
            this.cbxServis = new System.Windows.Forms.ComboBox();
            this.dtpDatumPocetkaRada = new System.Windows.Forms.DateTimePicker();
            this.brnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServis
            // 
            this.lblServis.AutoSize = true;
            this.lblServis.Location = new System.Drawing.Point(124, 58);
            this.lblServis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServis.Name = "lblServis";
            this.lblServis.Size = new System.Drawing.Size(39, 13);
            this.lblServis.TabIndex = 0;
            this.lblServis.Text = "Servis:";
            // 
            // lblDatumPocetakRada
            // 
            this.lblDatumPocetakRada.AutoSize = true;
            this.lblDatumPocetakRada.Location = new System.Drawing.Point(58, 102);
            this.lblDatumPocetakRada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumPocetakRada.Name = "lblDatumPocetakRada";
            this.lblDatumPocetakRada.Size = new System.Drawing.Size(107, 13);
            this.lblDatumPocetakRada.TabIndex = 1;
            this.lblDatumPocetakRada.Text = "Datum pocetka rada:";
            // 
            // cbxServis
            // 
            this.cbxServis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServis.FormattingEnabled = true;
            this.cbxServis.Location = new System.Drawing.Point(182, 55);
            this.cbxServis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxServis.Name = "cbxServis";
            this.cbxServis.Size = new System.Drawing.Size(167, 21);
            this.cbxServis.TabIndex = 2;
            // 
            // dtpDatumPocetkaRada
            // 
            this.dtpDatumPocetkaRada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPocetkaRada.Location = new System.Drawing.Point(182, 98);
            this.dtpDatumPocetkaRada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatumPocetkaRada.Name = "dtpDatumPocetkaRada";
            this.dtpDatumPocetkaRada.Size = new System.Drawing.Size(167, 20);
            this.dtpDatumPocetkaRada.TabIndex = 3;
            // 
            // brnOk
            // 
            this.brnOk.Location = new System.Drawing.Point(127, 153);
            this.brnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnOk.Name = "brnOk";
            this.brnOk.Size = new System.Drawing.Size(164, 29);
            this.brnOk.TabIndex = 4;
            this.brnOk.Text = "OK";
            this.brnOk.UseVisualStyleBackColor = true;
            this.brnOk.Click += new System.EventHandler(this.brnOk_Click);
            // 
            // AngazaujMehanicaraServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 218);
            this.Controls.Add(this.brnOk);
            this.Controls.Add(this.dtpDatumPocetkaRada);
            this.Controls.Add(this.cbxServis);
            this.Controls.Add(this.lblDatumPocetakRada);
            this.Controls.Add(this.lblServis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(439, 256);
            this.MinimumSize = new System.Drawing.Size(439, 256);
            this.Name = "AngazaujMehanicaraServis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angazuj mehanicara u servis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServis;
        private System.Windows.Forms.Label lblDatumPocetakRada;
        private System.Windows.Forms.ComboBox cbxServis;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetkaRada;
        private System.Windows.Forms.Button brnOk;
    }
}