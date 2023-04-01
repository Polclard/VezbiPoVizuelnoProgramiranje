namespace RezultatiKosarkaiFudbal
{
    partial class dodadiNatprevar
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
            groupBox1 = new GroupBox();
            tipNatprevarDropDown = new ComboBox();
            groupBox3 = new GroupBox();
            strelciGostiList = new TextBox();
            groupBox2 = new GroupBox();
            strelciDomaList = new TextBox();
            label5 = new Label();
            rezultatGosti = new TextBox();
            rezultatDomasni = new TextBox();
            textBoxGostin = new TextBox();
            textBoxDomakin = new TextBox();
            otkaziPrva = new Button();
            dodadiPrva = new Button();
            dodadiStrelciGosti = new Button();
            dodadiStrelciDoma = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tipNatprevarDropDown);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rezultatGosti);
            groupBox1.Controls.Add(rezultatDomasni);
            groupBox1.Controls.Add(textBoxGostin);
            groupBox1.Controls.Add(textBoxDomakin);
            groupBox1.Controls.Add(otkaziPrva);
            groupBox1.Controls.Add(dodadiPrva);
            groupBox1.Controls.Add(dodadiStrelciGosti);
            groupBox1.Controls.Add(dodadiStrelciDoma);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 436);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Внесете податоци";
            // 
            // tipNatprevarDropDown
            // 
            tipNatprevarDropDown.FormattingEnabled = true;
            tipNatprevarDropDown.Location = new Point(151, 47);
            tipNatprevarDropDown.Name = "tipNatprevarDropDown";
            tipNatprevarDropDown.Size = new Size(143, 23);
            tipNatprevarDropDown.TabIndex = 18;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(strelciGostiList);
            groupBox3.Location = new Point(210, 281);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(138, 82);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Стрелци гости";
            // 
            // strelciGostiList
            // 
            strelciGostiList.Location = new Point(6, 22);
            strelciGostiList.Multiline = true;
            strelciGostiList.Name = "strelciGostiList";
            strelciGostiList.Size = new Size(126, 54);
            strelciGostiList.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(strelciDomaList);
            groupBox2.Location = new Point(27, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 82);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Стрелци дома";
            // 
            // strelciDomaList
            // 
            strelciDomaList.Location = new Point(6, 22);
            strelciDomaList.Multiline = true;
            strelciDomaList.Name = "strelciDomaList";
            strelciDomaList.Size = new Size(132, 54);
            strelciDomaList.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 198);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 14;
            label5.Text = ":";
            // 
            // rezultatGosti
            // 
            rezultatGosti.Location = new Point(245, 198);
            rezultatGosti.Name = "rezultatGosti";
            rezultatGosti.Size = new Size(49, 23);
            rezultatGosti.TabIndex = 13;
            // 
            // rezultatDomasni
            // 
            rezultatDomasni.Location = new Point(151, 198);
            rezultatDomasni.Name = "rezultatDomasni";
            rezultatDomasni.Size = new Size(49, 23);
            rezultatDomasni.TabIndex = 12;
            // 
            // textBoxGostin
            // 
            textBoxGostin.Location = new Point(151, 143);
            textBoxGostin.Name = "textBoxGostin";
            textBoxGostin.Size = new Size(143, 23);
            textBoxGostin.TabIndex = 11;
            // 
            // textBoxDomakin
            // 
            textBoxDomakin.Location = new Point(151, 92);
            textBoxDomakin.Name = "textBoxDomakin";
            textBoxDomakin.Size = new Size(143, 23);
            textBoxDomakin.TabIndex = 10;
            // 
            // otkaziPrva
            // 
            otkaziPrva.Location = new Point(286, 407);
            otkaziPrva.Name = "otkaziPrva";
            otkaziPrva.Size = new Size(84, 23);
            otkaziPrva.TabIndex = 8;
            otkaziPrva.Text = "Откажи";
            otkaziPrva.UseVisualStyleBackColor = true;
            otkaziPrva.Click += otkaziPrva_Click;
            // 
            // dodadiPrva
            // 
            dodadiPrva.Location = new Point(197, 407);
            dodadiPrva.Name = "dodadiPrva";
            dodadiPrva.Size = new Size(84, 23);
            dodadiPrva.TabIndex = 7;
            dodadiPrva.Text = "Додади";
            dodadiPrva.UseVisualStyleBackColor = true;
            dodadiPrva.Click += dodadiPrva_Click;
            // 
            // dodadiStrelciGosti
            // 
            dodadiStrelciGosti.Location = new Point(210, 252);
            dodadiStrelciGosti.Name = "dodadiStrelciGosti";
            dodadiStrelciGosti.Size = new Size(138, 23);
            dodadiStrelciGosti.TabIndex = 5;
            dodadiStrelciGosti.Text = "Додади стрелци гости";
            dodadiStrelciGosti.UseVisualStyleBackColor = true;
            dodadiStrelciGosti.Click += dodadiStrelciGosti_Click;
            // 
            // dodadiStrelciDoma
            // 
            dodadiStrelciDoma.Location = new Point(27, 252);
            dodadiStrelciDoma.Name = "dodadiStrelciDoma";
            dodadiStrelciDoma.Size = new Size(144, 23);
            dodadiStrelciDoma.TabIndex = 4;
            dodadiStrelciDoma.Text = "Додади стрелци дома";
            dodadiStrelciDoma.UseVisualStyleBackColor = true;
            dodadiStrelciDoma.Click += dodadiStrelciDoma_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 195);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Резултат:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 146);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Гостин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 95);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Домаќин:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 50);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Тип на натпревар:";
            // 
            // dodadiNatprevar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 460);
            Controls.Add(groupBox1);
            Name = "dodadiNatprevar";
            Text = "dodadiNatprevar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private TextBox rezultatGosti;
        private TextBox rezultatDomasni;
        private TextBox textBoxGostin;
        private TextBox textBoxDomakin;
        private Button otkaziPrva;
        private Button dodadiPrva;
        private Button dodadiStrelciGosti;
        private Button dodadiStrelciDoma;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox strelciGostiList;
        private GroupBox groupBox2;
        private TextBox strelciDomaList;
        private ComboBox tipNatprevarDropDown;
    }
}