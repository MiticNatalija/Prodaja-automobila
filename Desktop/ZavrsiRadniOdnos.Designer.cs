namespace Desktop
{
    partial class ZavrsiRadniOdnos
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
            this.lblKrajRada = new System.Windows.Forms.Label();
            this.lblOcena = new System.Windows.Forms.Label();
            this.dtpKrajRada = new System.Windows.Forms.DateTimePicker();
            this.numOcena = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKrajRada
            // 
            this.lblKrajRada.AutoSize = true;
            this.lblKrajRada.Location = new System.Drawing.Point(37, 75);
            this.lblKrajRada.Name = "lblKrajRada";
            this.lblKrajRada.Size = new System.Drawing.Size(121, 17);
            this.lblKrajRada.TabIndex = 0;
            this.lblKrajRada.Text = "Datum kraja rada:";
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Location = new System.Drawing.Point(104, 122);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(54, 17);
            this.lblOcena.TabIndex = 1;
            this.lblOcena.Text = "Ocena:";
            // 
            // dtpKrajRada
            // 
            this.dtpKrajRada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKrajRada.Location = new System.Drawing.Point(195, 70);
            this.dtpKrajRada.Name = "dtpKrajRada";
            this.dtpKrajRada.Size = new System.Drawing.Size(134, 22);
            this.dtpKrajRada.TabIndex = 1;
            // 
            // numOcena
            // 
            this.numOcena.Location = new System.Drawing.Point(195, 120);
            this.numOcena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOcena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOcena.Name = "numOcena";
            this.numOcena.Size = new System.Drawing.Size(134, 22);
            this.numOcena.TabIndex = 2;
            this.numOcena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(91, 203);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(182, 45);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ZavrsiRadniOdnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 297);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numOcena);
            this.Controls.Add(this.dtpKrajRada);
            this.Controls.Add(this.lblOcena);
            this.Controls.Add(this.lblKrajRada);
            this.MaximumSize = new System.Drawing.Size(395, 344);
            this.MinimumSize = new System.Drawing.Size(395, 344);
            this.Name = "ZavrsiRadniOdnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacije o kraju radnog odnosa";
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKrajRada;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.DateTimePicker dtpKrajRada;
        private System.Windows.Forms.NumericUpDown numOcena;
        private System.Windows.Forms.Button btnOk;
    }
}