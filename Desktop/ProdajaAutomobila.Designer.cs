﻿namespace Desktop
{
    partial class btnVezaSeNalazi
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
            this.btnUcitajVozilo = new System.Windows.Forms.Button();
            this.btnUcitajKupca = new System.Windows.Forms.Button();
            this.cmdFizickoLice = new System.Windows.Forms.Button();
            this.btnVezaSe_nalazi = new System.Windows.Forms.Button();
            this.btnVlasnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitajVozilo
            // 
            this.btnUcitajVozilo.Location = new System.Drawing.Point(12, 12);
            this.btnUcitajVozilo.Name = "btnUcitajVozilo";
            this.btnUcitajVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajVozilo.TabIndex = 0;
            this.btnUcitajVozilo.Text = "Ucitaj vozilo";
            this.btnUcitajVozilo.UseVisualStyleBackColor = true;
            this.btnUcitajVozilo.Click += new System.EventHandler(this.btnUcitajVozilo_Click);
            // 
            // btnUcitajKupca
            // 
            this.btnUcitajKupca.Location = new System.Drawing.Point(12, 41);
            this.btnUcitajKupca.Name = "btnUcitajKupca";
            this.btnUcitajKupca.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajKupca.TabIndex = 1;
            this.btnUcitajKupca.Text = "Ucitaj kupca";
            this.btnUcitajKupca.UseVisualStyleBackColor = true;
            this.btnUcitajKupca.Click += new System.EventHandler(this.btnUcitajKupca_Click);
            // 
            // cmdFizickoLice
            // 
            this.cmdFizickoLice.Location = new System.Drawing.Point(13, 71);
            this.cmdFizickoLice.Name = "cmdFizickoLice";
            this.cmdFizickoLice.Size = new System.Drawing.Size(105, 23);
            this.cmdFizickoLice.TabIndex = 2;
            this.cmdFizickoLice.Text = "Ucitaj fizicko lice";
            this.cmdFizickoLice.UseVisualStyleBackColor = true;
            this.cmdFizickoLice.Click += new System.EventHandler(this.cmdFizickoLice_Click);
            // 
            // btnVezaSe_nalazi
            // 
            this.btnVezaSe_nalazi.Location = new System.Drawing.Point(12, 100);
            this.btnVezaSe_nalazi.Name = "btnVezaSe_nalazi";
            this.btnVezaSe_nalazi.Size = new System.Drawing.Size(106, 23);
            this.btnVezaSe_nalazi.TabIndex = 3;
            this.btnVezaSe_nalazi.Text = "Veza se_nalazi";
            this.btnVezaSe_nalazi.UseVisualStyleBackColor = true;
            this.btnVezaSe_nalazi.Click += new System.EventHandler(this.btnVezaSe_nalazi_Click);
            // 
            // btnVlasnik
            // 
            this.btnVlasnik.Location = new System.Drawing.Point(13, 130);
            this.btnVlasnik.Name = "btnVlasnik";
            this.btnVlasnik.Size = new System.Drawing.Size(75, 23);
            this.btnVlasnik.TabIndex = 4;
            this.btnVlasnik.Text = "Vlasnik";
            this.btnVlasnik.UseVisualStyleBackColor = true;
            this.btnVlasnik.Click += new System.EventHandler(this.btnVlasnik_Click);
            // 
            // btnVezaSeNalazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 372);
            this.Controls.Add(this.btnVlasnik);
            this.Controls.Add(this.btnVezaSe_nalazi);
            this.Controls.Add(this.cmdFizickoLice);
            this.Controls.Add(this.btnUcitajKupca);
            this.Controls.Add(this.btnUcitajVozilo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "btnVezaSeNalazi";
            this.Text = "Prodaja automobila";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajVozilo;
        private System.Windows.Forms.Button btnUcitajKupca;
        private System.Windows.Forms.Button cmdFizickoLice;
        private System.Windows.Forms.Button btnVezaSe_nalazi;
        private System.Windows.Forms.Button btnVlasnik;
    }
}

