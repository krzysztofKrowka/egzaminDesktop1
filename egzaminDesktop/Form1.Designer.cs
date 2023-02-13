namespace egzaminDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maleIwielkie = new System.Windows.Forms.CheckBox();
            this.cyfry = new System.Windows.Forms.CheckBox();
            this.znakiSpecjalne = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.ileZnakow = new System.Windows.Forms.TextBox();
            this.stanowisko = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dane pracownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stanowisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Generowanie hasła";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ile znaków?";
            // 
            // maleIwielkie
            // 
            this.maleIwielkie.AutoSize = true;
            this.maleIwielkie.Checked = true;
            this.maleIwielkie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.maleIwielkie.Location = new System.Drawing.Point(495, 120);
            this.maleIwielkie.Name = "maleIwielkie";
            this.maleIwielkie.Size = new System.Drawing.Size(126, 19);
            this.maleIwielkie.TabIndex = 6;
            this.maleIwielkie.Text = "Małe i wielkie litery";
            this.maleIwielkie.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            this.cyfry.AutoSize = true;
            this.cyfry.Location = new System.Drawing.Point(495, 156);
            this.cyfry.Name = "cyfry";
            this.cyfry.Size = new System.Drawing.Size(54, 19);
            this.cyfry.TabIndex = 7;
            this.cyfry.Text = "Cyfry";
            this.cyfry.UseVisualStyleBackColor = true;
            // 
            // znakiSpecjalne
            // 
            this.znakiSpecjalne.AutoSize = true;
            this.znakiSpecjalne.Location = new System.Drawing.Point(495, 191);
            this.znakiSpecjalne.Name = "znakiSpecjalne";
            this.znakiSpecjalne.Size = new System.Drawing.Size(107, 19);
            this.znakiSpecjalne.TabIndex = 8;
            this.znakiSpecjalne.Text = "Znaki specjalne";
            this.znakiSpecjalne.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(544, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generuj hasło";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.generujHaslo);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(230, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Zatwierdź";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.zatwierdz);
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(139, 85);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(100, 23);
            this.imie.TabIndex = 11;
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(149, 124);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(100, 23);
            this.nazwisko.TabIndex = 12;
            // 
            // ileZnakow
            // 
            this.ileZnakow.Location = new System.Drawing.Point(568, 85);
            this.ileZnakow.Name = "ileZnakow";
            this.ileZnakow.Size = new System.Drawing.Size(100, 23);
            this.ileZnakow.TabIndex = 13;
            // 
            // stanowisko
            // 
            this.stanowisko.FormattingEnabled = true;
            this.stanowisko.Items.AddRange(new object[] {
            "Kierownik",
            "Starszy programista",
            "Młodszy programista",
            "Tester"});
            this.stanowisko.Location = new System.Drawing.Point(158, 160);
            this.stanowisko.Name = "stanowisko";
            this.stanowisko.Size = new System.Drawing.Size(121, 23);
            this.stanowisko.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.stanowisko);
            this.Controls.Add(this.ileZnakow);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.znakiSpecjalne);
            this.Controls.Add(this.cyfry);
            this.Controls.Add(this.maleIwielkie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox maleIwielkie;
        private CheckBox cyfry;
        private CheckBox znakiSpecjalne;
        private Button button1;
        private Button button2;
        private TextBox imie;
        private TextBox nazwisko;
        private TextBox ileZnakow;
        private ComboBox stanowisko;
    }
}