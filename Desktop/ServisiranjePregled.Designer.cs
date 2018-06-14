namespace Desktop
{
    partial class frmServisiranjePregled
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
            this.dgvServisi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServisi
            // 
            this.dgvServisi.AllowUserToDeleteRows = false;
            this.dgvServisi.AllowUserToResizeColumns = false;
            this.dgvServisi.AllowUserToResizeRows = false;
            this.dgvServisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServisi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServisi.Location = new System.Drawing.Point(12, 12);
            this.dgvServisi.MultiSelect = false;
            this.dgvServisi.Name = "dgvServisi";
            this.dgvServisi.ReadOnly = true;
            this.dgvServisi.RowHeadersVisible = false;
            this.dgvServisi.Size = new System.Drawing.Size(494, 352);
            this.dgvServisi.TabIndex = 0;
            this.dgvServisi.DoubleClick += new System.EventHandler(this.dgvServisi_DoubleClick);
            // 
            // frmServisiranjePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 376);
            this.Controls.Add(this.dgvServisi);
            this.MaximizeBox = false;
            this.Name = "frmServisiranjePregled";
            this.Text = "Pregled servisa";
            this.Leave += new System.EventHandler(this.frmServisiranjePregled_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServisi;
    }
}