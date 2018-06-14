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
            this.dgvOceneMehanicara.Location = new System.Drawing.Point(10, 52);
            this.dgvOceneMehanicara.MultiSelect = false;
            this.dgvOceneMehanicara.Name = "dgvOceneMehanicara";
            this.dgvOceneMehanicara.ReadOnly = true;
            this.dgvOceneMehanicara.RowHeadersVisible = false;
            this.dgvOceneMehanicara.Size = new System.Drawing.Size(510, 119);
            this.dgvOceneMehanicara.TabIndex = 1;
            // 
            // dgvMehanicari
            // 
            this.dgvMehanicari.AllowUserToResizeRows = false;
            this.dgvMehanicari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMehanicari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMehanicari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMehanicari.Location = new System.Drawing.Point(10, 232);
            this.dgvMehanicari.MultiSelect = false;
            this.dgvMehanicari.Name = "dgvMehanicari";
            this.dgvMehanicari.ReadOnly = true;
            this.dgvMehanicari.RowTemplate.Height = 24;
            this.dgvMehanicari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMehanicari.Size = new System.Drawing.Size(510, 136);
            this.dgvMehanicari.TabIndex = 2;
            // 
            // lblOcenjeniMehanicari
            // 
            this.lblOcenjeniMehanicari.AutoSize = true;
            this.lblOcenjeniMehanicari.Location = new System.Drawing.Point(214, 20);
            this.lblOcenjeniMehanicari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOcenjeniMehanicari.Name = "lblOcenjeniMehanicari";
            this.lblOcenjeniMehanicari.Size = new System.Drawing.Size(106, 13);
            this.lblOcenjeniMehanicari.TabIndex = 3;
            this.lblOcenjeniMehanicari.Text = "Ocenjeni mehanicari:";
            // 
            // lblMehanicari
            // 
            this.lblMehanicari.AutoSize = true;
            this.lblMehanicari.Location = new System.Drawing.Point(148, 194);
            this.lblMehanicari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMehanicari.Name = "lblMehanicari";
            this.lblMehanicari.Size = new System.Drawing.Size(223, 13);
            this.lblMehanicari.TabIndex = 4;
            this.lblMehanicari.Text = "Mehanicari za Hyundai u servisi predstavnika:";
            this.lblMehanicari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOceniMehanicara
            // 
            this.btnOceniMehanicara.Location = new System.Drawing.Point(200, 391);
            this.btnOceniMehanicara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOceniMehanicara.Name = "btnOceniMehanicara";
            this.btnOceniMehanicara.Size = new System.Drawing.Size(129, 42);
            this.btnOceniMehanicara.TabIndex = 5;
            this.btnOceniMehanicara.Text = "Oceni mehanicara";
            this.btnOceniMehanicara.UseVisualStyleBackColor = true;
            this.btnOceniMehanicara.Click += new System.EventHandler(this.btnOceniMehanicara_Click);
            // 
            // OceneMehanicara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 443);
            this.Controls.Add(this.btnOceniMehanicara);
            this.Controls.Add(this.lblMehanicari);
            this.Controls.Add(this.lblOcenjeniMehanicari);
            this.Controls.Add(this.dgvMehanicari);
            this.Controls.Add(this.dgvOceneMehanicara);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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