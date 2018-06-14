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
            this.lblServis.Location = new System.Drawing.Point(166, 71);
            this.lblServis.Name = "lblServis";
            this.lblServis.Size = new System.Drawing.Size(51, 17);
            this.lblServis.TabIndex = 0;
            this.lblServis.Text = "Servis:";
            // 
            // lblDatumPocetakRada
            // 
            this.lblDatumPocetakRada.AutoSize = true;
            this.lblDatumPocetakRada.Location = new System.Drawing.Point(77, 126);
            this.lblDatumPocetakRada.Name = "lblDatumPocetakRada";
            this.lblDatumPocetakRada.Size = new System.Drawing.Size(140, 17);
            this.lblDatumPocetakRada.TabIndex = 1;
            this.lblDatumPocetakRada.Text = "Datum pocetka rada:";
            // 
            // cbxServis
            // 
            this.cbxServis.FormattingEnabled = true;
            this.cbxServis.Location = new System.Drawing.Point(243, 68);
            this.cbxServis.Name = "cbxServis";
            this.cbxServis.Size = new System.Drawing.Size(221, 24);
            this.cbxServis.TabIndex = 2;
            // 
            // dtpDatumPocetkaRada
            // 
            this.dtpDatumPocetkaRada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPocetkaRada.Location = new System.Drawing.Point(243, 121);
            this.dtpDatumPocetkaRada.Name = "dtpDatumPocetkaRada";
            this.dtpDatumPocetkaRada.Size = new System.Drawing.Size(221, 22);
            this.dtpDatumPocetkaRada.TabIndex = 3;
            // 
            // brnOk
            // 
            this.brnOk.Location = new System.Drawing.Point(169, 188);
            this.brnOk.Name = "brnOk";
            this.brnOk.Size = new System.Drawing.Size(219, 36);
            this.brnOk.TabIndex = 4;
            this.brnOk.Text = "OK";
            this.brnOk.UseVisualStyleBackColor = true;
            this.brnOk.Click += new System.EventHandler(this.brnOk_Click);
            // 
            // AngazaujMehanicaraServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 259);
            this.Controls.Add(this.brnOk);
            this.Controls.Add(this.dtpDatumPocetkaRada);
            this.Controls.Add(this.cbxServis);
            this.Controls.Add(this.lblDatumPocetakRada);
            this.Controls.Add(this.lblServis);
            this.MaximumSize = new System.Drawing.Size(580, 306);
            this.MinimumSize = new System.Drawing.Size(580, 306);
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