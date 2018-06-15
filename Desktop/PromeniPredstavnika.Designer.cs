namespace Desktop
{
    partial class frmPromeniPredstavnika
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
            this.cbxPredstavnici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttbtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxPredstavnici
            // 
            this.cbxPredstavnici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPredstavnici.FormattingEnabled = true;
            this.cbxPredstavnici.Location = new System.Drawing.Point(104, 48);
            this.cbxPredstavnici.Name = "cbxPredstavnici";
            this.cbxPredstavnici.Size = new System.Drawing.Size(139, 21);
            this.cbxPredstavnici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Predstavnici";
            // 
            // buttbtnOk
            // 
            this.buttbtnOk.Location = new System.Drawing.Point(104, 110);
            this.buttbtnOk.Name = "buttbtnOk";
            this.buttbtnOk.Size = new System.Drawing.Size(75, 23);
            this.buttbtnOk.TabIndex = 2;
            this.buttbtnOk.Text = "OK";
            this.buttbtnOk.UseVisualStyleBackColor = true;
            this.buttbtnOk.Click += new System.EventHandler(this.buttbtnOk_Click);
            // 
            // frmPromeniPredstavnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.buttbtnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPredstavnici);
            this.Name = "frmPromeniPredstavnika";
            this.Text = "PromeniPredstavnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPredstavnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttbtnOk;
    }
}