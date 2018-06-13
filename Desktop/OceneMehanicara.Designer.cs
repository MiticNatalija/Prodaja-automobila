namespace Desktop
{
    partial class OceneMehanicara
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
            this.dgvOceneMehanicara = new System.Windows.Forms.DataGridView();
            this.dgvMehanicari = new System.Windows.Forms.DataGridView();
            this.lblOcenjeniMehanicari = new System.Windows.Forms.Label();
            this.lblMehanicari = new System.Windows.Forms.Label();
            this.btnOceniMehanicara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOceneMehanicara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMehanicari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOceneMehanicara
            // 
            this.dgvOceneMehanicara.AllowUserToDeleteRows = false;
            this.dgvOceneMehanicara.AllowUserToResizeColumns = false;
            this.dgvOceneMehanicara.AllowUserToResizeRows = false;
            this.dgvOceneMehanicara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOceneMehanicara.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOceneMehanicara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOceneMehanicara.Enabled = false;
            this.dgvOceneMehanicara.Location = new System.Drawing.Point(13, 64);
            this.dgvOceneMehanicara.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOceneMehanicara.MultiSelect = false;
            this.dgvOceneMehanicara.Name = "dgvOceneMehanicara";
            this.dgvOceneMehanicara.ReadOnly = true;
            this.dgvOceneMehanicara.RowHeadersVisible = false;
            this.dgvOceneMehanicara.Size = new System.Drawing.Size(680, 146);
            this.dgvOceneMehanicara.TabIndex = 1;
            // 
            // dgvMehanicari
            // 
            this.dgvMehanicari.AllowUserToResizeRows = false;
            this.dgvMehanicari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMehanicari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMehanicari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMehanicari.Location = new System.Drawing.Point(13, 286);
            this.dgvMehanicari.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMehanicari.MultiSelect = false;
            this.dgvMehanicari.Name = "dgvMehanicari";
            this.dgvMehanicari.ReadOnly = true;
            this.dgvMehanicari.RowTemplate.Height = 24;
            this.dgvMehanicari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMehanicari.Size = new System.Drawing.Size(680, 167);
            this.dgvMehanicari.TabIndex = 2;
            // 
            // lblOcenjeniMehanicari
            // 
            this.lblOcenjeniMehanicari.AutoSize = true;
            this.lblOcenjeniMehanicari.Location = new System.Drawing.Point(286, 25);
            this.lblOcenjeniMehanicari.Name = "lblOcenjeniMehanicari";
            this.lblOcenjeniMehanicari.Size = new System.Drawing.Size(141, 17);
            this.lblOcenjeniMehanicari.TabIndex = 3;
            this.lblOcenjeniMehanicari.Text = "Ocenjeni mehanicari:";
            // 
            // lblMehanicari
            // 
            this.lblMehanicari.AutoSize = true;
            this.lblMehanicari.Location = new System.Drawing.Point(198, 239);
            this.lblMehanicari.Name = "lblMehanicari";
            this.lblMehanicari.Size = new System.Drawing.Size(297, 17);
            this.lblMehanicari.TabIndex = 4;
            this.lblMehanicari.Text = "Mehanicari za Hyundai u servisi predstavnika:";
            this.lblMehanicari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOceniMehanicara
            // 
            this.btnOceniMehanicara.Location = new System.Drawing.Point(267, 481);
            this.btnOceniMehanicara.Name = "btnOceniMehanicara";
            this.btnOceniMehanicara.Size = new System.Drawing.Size(172, 52);
            this.btnOceniMehanicara.TabIndex = 5;
            this.btnOceniMehanicara.Text = "Oceni mehanicara";
            this.btnOceniMehanicara.UseVisualStyleBackColor = true;
            // 
            // OceneMehanicara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 545);
            this.Controls.Add(this.btnOceniMehanicara);
            this.Controls.Add(this.lblMehanicari);
            this.Controls.Add(this.lblOcenjeniMehanicari);
            this.Controls.Add(this.dgvMehanicari);
            this.Controls.Add(this.dgvOceneMehanicara);
            this.Name = "OceneMehanicara";
            this.Text = "Ocene Mehanicara";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOceneMehanicara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMehanicari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOceneMehanicara;
        private System.Windows.Forms.DataGridView dgvMehanicari;
        private System.Windows.Forms.Label lblOcenjeniMehanicari;
        private System.Windows.Forms.Label lblMehanicari;
        private System.Windows.Forms.Button btnOceniMehanicara;
    }
}