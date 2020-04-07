namespace Program
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
            this.buttonZaszyfruj = new System.Windows.Forms.Button();
            this.checkBoxSpacja = new System.Windows.Forms.CheckBox();
            this.labelZnaki = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWejście = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWyjście = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKlucz = new System.Windows.Forms.TextBox();
            this.buttonOdszyfruj = new System.Windows.Forms.Button();
            this.checkBoxPolski = new System.Windows.Forms.CheckBox();
            this.textBoxCiąg = new System.Windows.Forms.TextBox();
            this.checkBoxMałe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonZaszyfruj
            // 
            this.buttonZaszyfruj.Location = new System.Drawing.Point(34, 164);
            this.buttonZaszyfruj.Name = "buttonZaszyfruj";
            this.buttonZaszyfruj.Size = new System.Drawing.Size(82, 73);
            this.buttonZaszyfruj.TabIndex = 1;
            this.buttonZaszyfruj.Text = "ZASZYFRUJ";
            this.buttonZaszyfruj.UseVisualStyleBackColor = true;
            this.buttonZaszyfruj.Click += new System.EventHandler(this.buttonZaszyfruj_Click);
            // 
            // checkBoxSpacja
            // 
            this.checkBoxSpacja.AutoSize = true;
            this.checkBoxSpacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxSpacja.Location = new System.Drawing.Point(362, 158);
            this.checkBoxSpacja.Name = "checkBoxSpacja";
            this.checkBoxSpacja.Size = new System.Drawing.Size(109, 44);
            this.checkBoxSpacja.TabIndex = 2;
            this.checkBoxSpacja.Text = "Uwzględnij\r\nspację\r\n";
            this.checkBoxSpacja.UseVisualStyleBackColor = true;
            this.checkBoxSpacja.CheckedChanged += new System.EventHandler(this.checkBoxSpacja_CheckedChanged);
            // 
            // labelZnaki
            // 
            this.labelZnaki.AutoSize = true;
            this.labelZnaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelZnaki.Location = new System.Drawing.Point(114, 9);
            this.labelZnaki.Name = "labelZnaki";
            this.labelZnaki.Size = new System.Drawing.Size(254, 26);
            this.labelZnaki.TabIndex = 3;
            this.labelZnaki.Text = "Ciąg dostępnych znaków";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(114, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tu wprowadź wiadomość:";
            // 
            // textBoxWejście
            // 
            this.textBoxWejście.Location = new System.Drawing.Point(12, 128);
            this.textBoxWejście.Name = "textBoxWejście";
            this.textBoxWejście.Size = new System.Drawing.Size(459, 20);
            this.textBoxWejście.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(7, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Twoja zaszyfrowana wiadomość:";
            // 
            // textBoxWyjście
            // 
            this.textBoxWyjście.Location = new System.Drawing.Point(12, 277);
            this.textBoxWyjście.Name = "textBoxWyjście";
            this.textBoxWyjście.Size = new System.Drawing.Size(325, 20);
            this.textBoxWyjście.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(267, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Klucz:";
            // 
            // textBoxKlucz
            // 
            this.textBoxKlucz.Location = new System.Drawing.Point(263, 193);
            this.textBoxKlucz.Name = "textBoxKlucz";
            this.textBoxKlucz.Size = new System.Drawing.Size(76, 20);
            this.textBoxKlucz.TabIndex = 9;
            // 
            // buttonOdszyfruj
            // 
            this.buttonOdszyfruj.Location = new System.Drawing.Point(144, 164);
            this.buttonOdszyfruj.Name = "buttonOdszyfruj";
            this.buttonOdszyfruj.Size = new System.Drawing.Size(84, 73);
            this.buttonOdszyfruj.TabIndex = 10;
            this.buttonOdszyfruj.Text = "ODSZYFRUJ";
            this.buttonOdszyfruj.UseVisualStyleBackColor = true;
            this.buttonOdszyfruj.Click += new System.EventHandler(this.buttonOdszyfruj_Click);
            // 
            // checkBoxPolski
            // 
            this.checkBoxPolski.AutoSize = true;
            this.checkBoxPolski.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxPolski.Location = new System.Drawing.Point(362, 208);
            this.checkBoxPolski.Name = "checkBoxPolski";
            this.checkBoxPolski.Size = new System.Drawing.Size(109, 44);
            this.checkBoxPolski.TabIndex = 11;
            this.checkBoxPolski.Text = "Uwzględnij\r\npolskie\r\n";
            this.checkBoxPolski.UseVisualStyleBackColor = true;
            this.checkBoxPolski.CheckedChanged += new System.EventHandler(this.checkBoxPolski_CheckedChanged);
            // 
            // textBoxCiąg
            // 
            this.textBoxCiąg.Location = new System.Drawing.Point(110, 38);
            this.textBoxCiąg.Multiline = true;
            this.textBoxCiąg.Name = "textBoxCiąg";
            this.textBoxCiąg.ReadOnly = true;
            this.textBoxCiąg.Size = new System.Drawing.Size(258, 46);
            this.textBoxCiąg.TabIndex = 12;
            // 
            // checkBoxMałe
            // 
            this.checkBoxMałe.AutoSize = true;
            this.checkBoxMałe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxMałe.Location = new System.Drawing.Point(361, 260);
            this.checkBoxMałe.Name = "checkBoxMałe";
            this.checkBoxMałe.Size = new System.Drawing.Size(109, 44);
            this.checkBoxMałe.TabIndex = 13;
            this.checkBoxMałe.Text = "Uwzględnij\r\nmałe\r\n";
            this.checkBoxMałe.UseVisualStyleBackColor = true;
            this.checkBoxMałe.CheckedChanged += new System.EventHandler(this.checkBoxMałe_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 318);
            this.Controls.Add(this.checkBoxMałe);
            this.Controls.Add(this.textBoxCiąg);
            this.Controls.Add(this.checkBoxPolski);
            this.Controls.Add(this.buttonOdszyfruj);
            this.Controls.Add(this.textBoxKlucz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWyjście);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWejście);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelZnaki);
            this.Controls.Add(this.checkBoxSpacja);
            this.Controls.Add(this.buttonZaszyfruj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Szyfr Cezara - Michał Hałdaś";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonZaszyfruj;
        private System.Windows.Forms.CheckBox checkBoxSpacja;
        private System.Windows.Forms.Label labelZnaki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWejście;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWyjście;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKlucz;
        private System.Windows.Forms.Button buttonOdszyfruj;
        private System.Windows.Forms.CheckBox checkBoxPolski;
        private System.Windows.Forms.TextBox textBoxCiąg;
        private System.Windows.Forms.CheckBox checkBoxMałe;
    }
}

