namespace RR_Linolejs
{
    partial class Form1
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
            this.cena = new System.Windows.Forms.Label();
            this.platums = new System.Windows.Forms.Label();
            this.telpa = new System.Windows.Forms.Label();
            this.telpa2garums = new System.Windows.Forms.Label();
            this.izmaksas = new System.Windows.Forms.Label();
            this.aprekinat = new System.Windows.Forms.Button();
            this.ievadcena = new System.Windows.Forms.TextBox();
            this.ievadrulplatums = new System.Windows.Forms.TextBox();
            this.ievadtelpplatums = new System.Windows.Forms.TextBox();
            this.ievadtelpgarums = new System.Windows.Forms.TextBox();
            this.izvadizmaksas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Location = new System.Drawing.Point(47, 74);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(152, 13);
            this.cena.TabIndex = 0;
            this.cena.Text = "Ievadiet linoleja cenu EUR/m2";
            // 
            // platums
            // 
            this.platums.AutoSize = true;
            this.platums.Location = new System.Drawing.Point(47, 100);
            this.platums.Name = "platums";
            this.platums.Size = new System.Drawing.Size(176, 13);
            this.platums.TabIndex = 1;
            this.platums.Text = "Ievadiet linoleja ruļļa platumu metros";
            this.platums.Click += new System.EventHandler(this.label2_Click);
            // 
            // telpa
            // 
            this.telpa.AutoSize = true;
            this.telpa.Location = new System.Drawing.Point(47, 124);
            this.telpa.Name = "telpa";
            this.telpa.Size = new System.Drawing.Size(150, 13);
            this.telpa.TabIndex = 2;
            this.telpa.Text = "Ievadiet telpas platumu metros";
            // 
            // telpa2garums
            // 
            this.telpa2garums.AutoSize = true;
            this.telpa2garums.Location = new System.Drawing.Point(47, 154);
            this.telpa2garums.Name = "telpa2garums";
            this.telpa2garums.Size = new System.Drawing.Size(148, 13);
            this.telpa2garums.TabIndex = 3;
            this.telpa2garums.Text = "Ievadiet telpas garumu metros";
            // 
            // izmaksas
            // 
            this.izmaksas.AutoSize = true;
            this.izmaksas.Location = new System.Drawing.Point(47, 189);
            this.izmaksas.Name = "izmaksas";
            this.izmaksas.Size = new System.Drawing.Size(77, 13);
            this.izmaksas.TabIndex = 4;
            this.izmaksas.Text = "Izmaksas EUR";
            this.izmaksas.Click += new System.EventHandler(this.izmaksas_Click);
            // 
            // aprekinat
            // 
            this.aprekinat.Location = new System.Drawing.Point(50, 218);
            this.aprekinat.Name = "aprekinat";
            this.aprekinat.Size = new System.Drawing.Size(75, 23);
            this.aprekinat.TabIndex = 5;
            this.aprekinat.Text = "Aprēķināt";
            this.aprekinat.UseVisualStyleBackColor = true;
            // 
            // ievadcena
            // 
            this.ievadcena.Location = new System.Drawing.Point(206, 74);
            this.ievadcena.Name = "ievadcena";
            this.ievadcena.Size = new System.Drawing.Size(100, 20);
            this.ievadcena.TabIndex = 6;
            this.ievadcena.TextChanged += new System.EventHandler(this.ievadcena_TextChanged);
            // 
            // ievadrulplatums
            // 
            this.ievadrulplatums.Location = new System.Drawing.Point(230, 101);
            this.ievadrulplatums.Name = "ievadrulplatums";
            this.ievadrulplatums.Size = new System.Drawing.Size(100, 20);
            this.ievadrulplatums.TabIndex = 7;
            this.ievadrulplatums.TextChanged += new System.EventHandler(this.ievadrulplatums_TextChanged);
            // 
            // ievadtelpplatums
            // 
            this.ievadtelpplatums.Location = new System.Drawing.Point(204, 124);
            this.ievadtelpplatums.Name = "ievadtelpplatums";
            this.ievadtelpplatums.Size = new System.Drawing.Size(100, 20);
            this.ievadtelpplatums.TabIndex = 8;
            // 
            // ievadtelpgarums
            // 
            this.ievadtelpgarums.Location = new System.Drawing.Point(202, 154);
            this.ievadtelpgarums.Name = "ievadtelpgarums";
            this.ievadtelpgarums.Size = new System.Drawing.Size(100, 20);
            this.ievadtelpgarums.TabIndex = 9;
        
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izvadizmaksas);
            this.Controls.Add(this.ievadtelpgarums);
            this.Controls.Add(this.ievadtelpplatums);
            this.Controls.Add(this.ievadrulplatums);
            this.Controls.Add(this.ievadcena);
            this.Controls.Add(this.aprekinat);
            this.Controls.Add(this.izmaksas);
            this.Controls.Add(this.telpa2garums);
            this.Controls.Add(this.telpa);
            this.Controls.Add(this.platums);
            this.Controls.Add(this.cena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.Label platums;
        private System.Windows.Forms.Label telpa;
        private System.Windows.Forms.Label telpa2garums;
        private System.Windows.Forms.Label izmaksas;
        private System.Windows.Forms.Button aprekinat;
        private System.Windows.Forms.TextBox ievadcena;
        private System.Windows.Forms.TextBox ievadrulplatums;
        private System.Windows.Forms.TextBox ievadtelpplatums;
        private System.Windows.Forms.TextBox ievadtelpgarums;
        private System.Windows.Forms.TextBox izvadizmaksas;
    }
}

