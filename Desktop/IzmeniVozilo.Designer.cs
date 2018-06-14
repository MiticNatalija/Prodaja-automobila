namespace Desktop
{
    partial class frmIzmeniVozilo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtGorivo = new System.Windows.Forms.TextBox();
            this.txtTipVozila = new System.Windows.Forms.TextBox();
            this.txtBrojMesta = new System.Windows.Forms.TextBox();
            this.txtNosivost = new System.Windows.Forms.TextBox();
            this.txtOznakaMotora = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registracija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gorivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip vozila:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj mesta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nosivost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oznaka motora:";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(122, 27);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(100, 20);
            this.txtRegistracija.TabIndex = 6;
            // 
            // txtGorivo
            // 
            this.txtGorivo.Location = new System.Drawing.Point(122, 61);
            this.txtGorivo.Name = "txtGorivo";
            this.txtGorivo.Size = new System.Drawing.Size(100, 20);
            this.txtGorivo.TabIndex = 7;
            // 
            // txtTipVozila
            // 
            this.txtTipVozila.Location = new System.Drawing.Point(122, 94);
            this.txtTipVozila.Name = "txtTipVozila";
            this.txtTipVozila.Size = new System.Drawing.Size(100, 20);
            this.txtTipVozila.TabIndex = 8;
            // 
            // txtBrojMesta
            // 
            this.txtBrojMesta.Location = new System.Drawing.Point(122, 123);
            this.txtBrojMesta.Name = "txtBrojMesta";
            this.txtBrojMesta.Size = new System.Drawing.Size(100, 20);
            this.txtBrojMesta.TabIndex = 9;
            this.txtBrojMesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojMesta_KeyPress);
            // 
            // txtNosivost
            // 
            this.txtNosivost.Location = new System.Drawing.Point(122, 166);
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.Size = new System.Drawing.Size(100, 20);
            this.txtNosivost.TabIndex = 10;
            this.txtNosivost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNosivost_KeyPress);
            // 
            // txtOznakaMotora
            // 
            this.txtOznakaMotora.Location = new System.Drawing.Point(122, 209);
            this.txtOznakaMotora.Name = "txtOznakaMotora";
            this.txtOznakaMotora.Size = new System.Drawing.Size(100, 20);
            this.txtOznakaMotora.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(122, 264);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 35);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmIzmeniVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 322);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtOznakaMotora);
            this.Controls.Add(this.txtNosivost);
            this.Controls.Add(this.txtBrojMesta);
            this.Controls.Add(this.txtTipVozila);
            this.Controls.Add(this.txtGorivo);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIzmeniVozilo";
            this.Text = "Izmeni vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtGorivo;
        private System.Windows.Forms.TextBox txtTipVozila;
        private System.Windows.Forms.TextBox txtBrojMesta;
        private System.Windows.Forms.TextBox txtNosivost;
        private System.Windows.Forms.TextBox txtOznakaMotora;
        private System.Windows.Forms.Button btnOK;
    }
}