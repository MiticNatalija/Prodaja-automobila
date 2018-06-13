namespace Desktop
{
    partial class frmDodajPredstavnistvo
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
            this.btnOk = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblDatumOtvaranja = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.lblDatumVazenjaLicence = new System.Windows.Forms.Label();
            this.lblHyundaiLicenca = new System.Windows.Forms.Label();
            this.dtpLicenca = new System.Windows.Forms.DateTimePicker();
            this.lblPredstavnikKia = new System.Windows.Forms.Label();
            this.cbxPredstavnikKia = new System.Windows.Forms.ComboBox();
            this.cbxPredstavnikHyundai = new System.Windows.Forms.ComboBox();
            this.lblPredstavnikHyundai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(157, 372);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(214, 28);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(292, 69);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(160, 22);
            this.dtpDatum.TabIndex = 9;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(292, 16);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(160, 22);
            this.txtAdresa.TabIndex = 8;
            // 
            // lblDatumOtvaranja
            // 
            this.lblDatumOtvaranja.AutoSize = true;
            this.lblDatumOtvaranja.Location = new System.Drawing.Point(124, 74);
            this.lblDatumOtvaranja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumOtvaranja.Name = "lblDatumOtvaranja";
            this.lblDatumOtvaranja.Size = new System.Drawing.Size(116, 17);
            this.lblDatumOtvaranja.TabIndex = 7;
            this.lblDatumOtvaranja.Text = "Datum otvaranja:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(183, 19);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(57, 17);
            this.lblAdresa.TabIndex = 6;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(208, 121);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(32, 17);
            this.lblTip.TabIndex = 11;
            this.lblTip.Text = "Tip:";
            // 
            // cbxTip
            // 
            this.cbxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTip.FormattingEnabled = true;
            this.cbxTip.Location = new System.Drawing.Point(292, 118);
            this.cbxTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(160, 24);
            this.cbxTip.TabIndex = 12;
            this.cbxTip.SelectedIndexChanged += new System.EventHandler(this.cbxTip_SelectedIndexChanged);
            // 
            // lblDatumVazenjaLicence
            // 
            this.lblDatumVazenjaLicence.AutoSize = true;
            this.lblDatumVazenjaLicence.Location = new System.Drawing.Point(86, 283);
            this.lblDatumVazenjaLicence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumVazenjaLicence.Name = "lblDatumVazenjaLicence";
            this.lblDatumVazenjaLicence.Size = new System.Drawing.Size(154, 17);
            this.lblDatumVazenjaLicence.TabIndex = 13;
            this.lblDatumVazenjaLicence.Text = "Datum vazenja licence:";
            // 
            // lblHyundaiLicenca
            // 
            this.lblHyundaiLicenca.AutoSize = true;
            this.lblHyundaiLicenca.BackColor = System.Drawing.SystemColors.Control;
            this.lblHyundaiLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHyundaiLicenca.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHyundaiLicenca.Location = new System.Drawing.Point(29, 300);
            this.lblHyundaiLicenca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHyundaiLicenca.Name = "lblHyundaiLicenca";
            this.lblHyundaiLicenca.Size = new System.Drawing.Size(211, 15);
            this.lblHyundaiLicenca.TabIndex = 14;
            this.lblHyundaiLicenca.Text = "Samo za salone koji prodaju Hyundai";
            // 
            // dtpLicenca
            // 
            this.dtpLicenca.Enabled = false;
            this.dtpLicenca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLicenca.Location = new System.Drawing.Point(292, 291);
            this.dtpLicenca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpLicenca.Name = "dtpLicenca";
            this.dtpLicenca.Size = new System.Drawing.Size(160, 22);
            this.dtpLicenca.TabIndex = 15;
            // 
            // lblPredstavnikKia
            // 
            this.lblPredstavnikKia.AutoSize = true;
            this.lblPredstavnikKia.Location = new System.Drawing.Point(130, 175);
            this.lblPredstavnikKia.Name = "lblPredstavnikKia";
            this.lblPredstavnikKia.Size = new System.Drawing.Size(110, 17);
            this.lblPredstavnikKia.TabIndex = 16;
            this.lblPredstavnikKia.Text = "Predstavnik Kia:";
            // 
            // cbxPredstavnikKia
            // 
            this.cbxPredstavnikKia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPredstavnikKia.Enabled = false;
            this.cbxPredstavnikKia.FormattingEnabled = true;
            this.cbxPredstavnikKia.Location = new System.Drawing.Point(292, 172);
            this.cbxPredstavnikKia.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPredstavnikKia.Name = "cbxPredstavnikKia";
            this.cbxPredstavnikKia.Size = new System.Drawing.Size(160, 24);
            this.cbxPredstavnikKia.TabIndex = 17;
            // 
            // cbxPredstavnikHyundai
            // 
            this.cbxPredstavnikHyundai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPredstavnikHyundai.Enabled = false;
            this.cbxPredstavnikHyundai.FormattingEnabled = true;
            this.cbxPredstavnikHyundai.Location = new System.Drawing.Point(292, 229);
            this.cbxPredstavnikHyundai.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPredstavnikHyundai.Name = "cbxPredstavnikHyundai";
            this.cbxPredstavnikHyundai.Size = new System.Drawing.Size(160, 24);
            this.cbxPredstavnikHyundai.TabIndex = 19;
            // 
            // lblPredstavnikHyundai
            // 
            this.lblPredstavnikHyundai.AutoSize = true;
            this.lblPredstavnikHyundai.Location = new System.Drawing.Point(98, 232);
            this.lblPredstavnikHyundai.Name = "lblPredstavnikHyundai";
            this.lblPredstavnikHyundai.Size = new System.Drawing.Size(142, 17);
            this.lblPredstavnikHyundai.TabIndex = 18;
            this.lblPredstavnikHyundai.Text = "Predstavnik Hyundai:";
            // 
            // frmDodajPredstavnistvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 423);
            this.Controls.Add(this.cbxPredstavnikHyundai);
            this.Controls.Add(this.lblPredstavnikHyundai);
            this.Controls.Add(this.cbxPredstavnikKia);
            this.Controls.Add(this.lblPredstavnikKia);
            this.Controls.Add(this.dtpLicenca);
            this.Controls.Add(this.lblHyundaiLicenca);
            this.Controls.Add(this.lblDatumVazenjaLicence);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblDatumOtvaranja);
            this.Controls.Add(this.lblAdresa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDodajPredstavnistvo";
            this.Text = "frmDodajPredstavnistvo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblDatumOtvaranja;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.Label lblDatumVazenjaLicence;
        private System.Windows.Forms.Label lblHyundaiLicenca;
        private System.Windows.Forms.DateTimePicker dtpLicenca;
        private System.Windows.Forms.Label lblPredstavnikKia;
        private System.Windows.Forms.ComboBox cbxPredstavnikKia;
        private System.Windows.Forms.ComboBox cbxPredstavnikHyundai;
        private System.Windows.Forms.Label lblPredstavnikHyundai;
    }
}