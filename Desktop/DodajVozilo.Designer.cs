namespace Desktop
{
    partial class frmDodajVozilo
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
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.lblGorivo = new System.Windows.Forms.Label();
            this.lblTipVozila = new System.Windows.Forms.Label();
            this.lblBrojMesta = new System.Windows.Forms.Label();
            this.lblNosivost = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtGorivo = new System.Windows.Forms.TextBox();
            this.txtBrojMesta = new System.Windows.Forms.TextBox();
            this.txtNosivost = new System.Windows.Forms.TextBox();
            this.cbxTipVozila = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtOznakaMotora = new System.Windows.Forms.TextBox();
            this.lblOznakaMotora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Location = new System.Drawing.Point(24, 49);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(65, 13);
            this.lblRegistracija.TabIndex = 0;
            this.lblRegistracija.Text = "Registracija:";
            // 
            // lblGorivo
            // 
            this.lblGorivo.AutoSize = true;
            this.lblGorivo.Location = new System.Drawing.Point(24, 88);
            this.lblGorivo.Name = "lblGorivo";
            this.lblGorivo.Size = new System.Drawing.Size(41, 13);
            this.lblGorivo.TabIndex = 1;
            this.lblGorivo.Text = "Gorivo:";
            // 
            // lblTipVozila
            // 
            this.lblTipVozila.AutoSize = true;
            this.lblTipVozila.Location = new System.Drawing.Point(24, 136);
            this.lblTipVozila.Name = "lblTipVozila";
            this.lblTipVozila.Size = new System.Drawing.Size(55, 13);
            this.lblTipVozila.TabIndex = 2;
            this.lblTipVozila.Text = "Tip vozila:";
            // 
            // lblBrojMesta
            // 
            this.lblBrojMesta.AutoSize = true;
            this.lblBrojMesta.Location = new System.Drawing.Point(24, 168);
            this.lblBrojMesta.Name = "lblBrojMesta";
            this.lblBrojMesta.Size = new System.Drawing.Size(59, 13);
            this.lblBrojMesta.TabIndex = 3;
            this.lblBrojMesta.Text = "Broj mesta:";
            // 
            // lblNosivost
            // 
            this.lblNosivost.AutoSize = true;
            this.lblNosivost.Location = new System.Drawing.Point(24, 212);
            this.lblNosivost.Name = "lblNosivost";
            this.lblNosivost.Size = new System.Drawing.Size(51, 13);
            this.lblNosivost.TabIndex = 4;
            this.lblNosivost.Text = "Nosivost:";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(125, 46);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(125, 20);
            this.txtRegistracija.TabIndex = 5;
            // 
            // txtGorivo
            // 
            this.txtGorivo.Location = new System.Drawing.Point(125, 85);
            this.txtGorivo.Name = "txtGorivo";
            this.txtGorivo.Size = new System.Drawing.Size(125, 20);
            this.txtGorivo.TabIndex = 6;
            this.txtGorivo.Leave += new System.EventHandler(this.txtGorivo_Leave);
            // 
            // txtBrojMesta
            // 
            this.txtBrojMesta.Location = new System.Drawing.Point(125, 165);
            this.txtBrojMesta.Name = "txtBrojMesta";
            this.txtBrojMesta.Size = new System.Drawing.Size(125, 20);
            this.txtBrojMesta.TabIndex = 7;
            this.txtBrojMesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojMesta_KeyPress);
            // 
            // txtNosivost
            // 
            this.txtNosivost.Location = new System.Drawing.Point(125, 212);
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.Size = new System.Drawing.Size(125, 20);
            this.txtNosivost.TabIndex = 8;
            this.txtNosivost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNosivost_KeyPress);
            // 
            // cbxTipVozila
            // 
            this.cbxTipVozila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipVozila.FormattingEnabled = true;
            this.cbxTipVozila.Location = new System.Drawing.Point(125, 128);
            this.cbxTipVozila.Name = "cbxTipVozila";
            this.cbxTipVozila.Size = new System.Drawing.Size(125, 21);
            this.cbxTipVozila.TabIndex = 9;
            this.cbxTipVozila.SelectedIndexChanged += new System.EventHandler(this.cbxTipVozila_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(125, 313);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 35);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtOznakaMotora
            // 
            this.txtOznakaMotora.Location = new System.Drawing.Point(125, 257);
            this.txtOznakaMotora.Name = "txtOznakaMotora";
            this.txtOznakaMotora.Size = new System.Drawing.Size(125, 20);
            this.txtOznakaMotora.TabIndex = 11;
            // 
            // lblOznakaMotora
            // 
            this.lblOznakaMotora.AutoSize = true;
            this.lblOznakaMotora.Location = new System.Drawing.Point(12, 257);
            this.lblOznakaMotora.Name = "lblOznakaMotora";
            this.lblOznakaMotora.Size = new System.Drawing.Size(82, 13);
            this.lblOznakaMotora.TabIndex = 12;
            this.lblOznakaMotora.Text = "Oznaka motora:";
            // 
            // frmDodajVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 360);
            this.Controls.Add(this.lblOznakaMotora);
            this.Controls.Add(this.txtOznakaMotora);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxTipVozila);
            this.Controls.Add(this.txtNosivost);
            this.Controls.Add(this.txtBrojMesta);
            this.Controls.Add(this.txtGorivo);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.lblNosivost);
            this.Controls.Add(this.lblBrojMesta);
            this.Controls.Add(this.lblTipVozila);
            this.Controls.Add(this.lblGorivo);
            this.Controls.Add(this.lblRegistracija);
            this.Name = "frmDodajVozilo";
            this.Text = "Dodaj vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.Label lblGorivo;
        private System.Windows.Forms.Label lblTipVozila;
        private System.Windows.Forms.Label lblBrojMesta;
        private System.Windows.Forms.Label lblNosivost;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtGorivo;
        private System.Windows.Forms.TextBox txtBrojMesta;
        private System.Windows.Forms.TextBox txtNosivost;
        private System.Windows.Forms.ComboBox cbxTipVozila;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtOznakaMotora;
        private System.Windows.Forms.Label lblOznakaMotora;
    }
}