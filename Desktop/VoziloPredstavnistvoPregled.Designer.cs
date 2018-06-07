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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.AllowUserToResizeRows = false;
            this.dgvAutomobili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutomobili.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.Location = new System.Drawing.Point(12, 11);
            this.dgvAutomobili.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAutomobili.MultiSelect = false;
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.ReadOnly = true;
            this.dgvAutomobili.RowTemplate.Height = 24;
            this.dgvAutomobili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomobili.Size = new System.Drawing.Size(631, 498);
            this.dgvAutomobili.TabIndex = 1;
            // 
            // VoziloPredstavnistvoPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 520);
            this.Controls.Add(this.dgvAutomobili);
            this.Name = "VoziloPredstavnistvoPregled";
            this.Text = "Vozilo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomobili;
    }
}