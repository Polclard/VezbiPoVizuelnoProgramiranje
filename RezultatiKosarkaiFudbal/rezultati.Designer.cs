namespace RezultatiKosarkaiFudbal
{
    partial class rezultati
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
            zatvoriProzorec = new Button();
            dodadiNatprevar = new Button();
            groupBox3 = new GroupBox();
            tim2 = new TextBox();
            rezultat = new TextBox();
            tim1 = new TextBox();
            strelciGostin = new ListBox();
            strelciDomasen = new ListBox();
            dataNaIgranje = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBoxFudbal = new ListBox();
            groupBox1 = new GroupBox();
            listBoxKosarka = new ListBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // zatvoriProzorec
            // 
            zatvoriProzorec.Location = new Point(364, 536);
            zatvoriProzorec.Name = "zatvoriProzorec";
            zatvoriProzorec.Size = new Size(332, 23);
            zatvoriProzorec.TabIndex = 16;
            zatvoriProzorec.Text = "Затвори прозорец";
            zatvoriProzorec.UseVisualStyleBackColor = true;
            zatvoriProzorec.Click += zatvoriProzorec_Click;
            // 
            // dodadiNatprevar
            // 
            dodadiNatprevar.Location = new Point(18, 536);
            dodadiNatprevar.Name = "dodadiNatprevar";
            dodadiNatprevar.Size = new Size(332, 23);
            dodadiNatprevar.TabIndex = 15;
            dodadiNatprevar.Text = "Додади натпревар";
            dodadiNatprevar.UseVisualStyleBackColor = true;
            dodadiNatprevar.Click += dodadiNatprevar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tim2);
            groupBox3.Controls.Add(rezultat);
            groupBox3.Controls.Add(tim1);
            groupBox3.Controls.Add(strelciGostin);
            groupBox3.Controls.Add(strelciDomasen);
            groupBox3.Controls.Add(dataNaIgranje);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(18, 309);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(677, 214);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Детали за натпревар";
            // 
            // tim2
            // 
            tim2.Location = new Point(434, 38);
            tim2.Name = "tim2";
            tim2.ReadOnly = true;
            tim2.Size = new Size(163, 23);
            tim2.TabIndex = 9;
            // 
            // rezultat
            // 
            rezultat.Location = new Point(291, 36);
            rezultat.Name = "rezultat";
            rezultat.ReadOnly = true;
            rezultat.Size = new Size(100, 23);
            rezultat.TabIndex = 8;
            // 
            // tim1
            // 
            tim1.Location = new Point(81, 36);
            tim1.Name = "tim1";
            tim1.ReadOnly = true;
            tim1.Size = new Size(163, 23);
            tim1.TabIndex = 7;
            // 
            // strelciGostin
            // 
            strelciGostin.FormattingEnabled = true;
            strelciGostin.ItemHeight = 15;
            strelciGostin.Location = new Point(434, 82);
            strelciGostin.Name = "strelciGostin";
            strelciGostin.Size = new Size(163, 94);
            strelciGostin.TabIndex = 6;
            // 
            // strelciDomasen
            // 
            strelciDomasen.FormattingEnabled = true;
            strelciDomasen.ItemHeight = 15;
            strelciDomasen.Location = new Point(81, 82);
            strelciDomasen.Name = "strelciDomasen";
            strelciDomasen.Size = new Size(163, 94);
            strelciDomasen.TabIndex = 5;
            // 
            // dataNaIgranje
            // 
            dataNaIgranje.Location = new Point(81, 182);
            dataNaIgranje.Name = "dataNaIgranje";
            dataNaIgranje.ReadOnly = true;
            dataNaIgranje.Size = new Size(172, 23);
            dataNaIgranje.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 64);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Стрелци:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 64);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Стрелци:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 185);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Одржан на:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Натпревар:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxFudbal);
            groupBox2.Location = new Point(388, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 241);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фудбал";
            // 
            // listBoxFudbal
            // 
            listBoxFudbal.FormattingEnabled = true;
            listBoxFudbal.ItemHeight = 15;
            listBoxFudbal.Location = new Point(14, 22);
            listBoxFudbal.Name = "listBoxFudbal";
            listBoxFudbal.Size = new Size(287, 184);
            listBoxFudbal.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxKosarka);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 241);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Кошарка";
            // 
            // listBoxKosarka
            // 
            listBoxKosarka.FormattingEnabled = true;
            listBoxKosarka.ItemHeight = 15;
            listBoxKosarka.Location = new Point(6, 22);
            listBoxKosarka.Name = "listBoxKosarka";
            listBoxKosarka.Size = new Size(287, 184);
            listBoxKosarka.TabIndex = 0;
            // 
            // rezultati
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 579);
            Controls.Add(zatvoriProzorec);
            Controls.Add(dodadiNatprevar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "rezultati";
            Text = "rezultati";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button zatvoriProzorec;
        private Button dodadiNatprevar;
        private GroupBox groupBox3;
        private TextBox tim2;
        private TextBox rezultat;
        private TextBox tim1;
        private ListBox strelciGostin;
        private ListBox strelciDomasen;
        private TextBox dataNaIgranje;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListBox listBoxFudbal;
        private GroupBox groupBox1;
        private ListBox listBoxKosarka;
    }
}