namespace NarackaNaPica
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
            groupBoxGolemina = new GroupBox();
            cenaGolema = new TextBox();
            cenaSredna = new TextBox();
            cenaMala = new TextBox();
            golema = new RadioButton();
            sredna = new RadioButton();
            mala = new RadioButton();
            groupBoxDodatoci = new GroupBox();
            cenaKecap = new TextBox();
            cenaEkstraSirenje = new TextBox();
            cenaFeferoni = new TextBox();
            checkBoxKecap = new CheckBox();
            checkBoxEkstraSirenje = new CheckBox();
            checkBoxFeferoni = new CheckBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            vkunpPivo = new TextBox();
            vkupnoJP = new TextBox();
            vkupnoKFS = new TextBox();
            cenaPivo = new TextBox();
            cenaJP = new TextBox();
            label5 = new Label();
            cenaKFS = new TextBox();
            kolicinaPivo = new TextBox();
            kolicinaJP = new TextBox();
            label4 = new Label();
            kolicinaKFS = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listDeserts = new ListBox();
            buttonOtkazi = new Button();
            buttonNaracaj = new Button();
            label7 = new Label();
            cenaDesert = new TextBox();
            groupBox3 = new GroupBox();
            zaVrakjanje = new TextBox();
            naplateno = new TextBox();
            vkupnoZaNaplata = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBoxGolemina.SuspendLayout();
            groupBoxDodatoci.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGolemina
            // 
            groupBoxGolemina.Controls.Add(cenaGolema);
            groupBoxGolemina.Controls.Add(cenaSredna);
            groupBoxGolemina.Controls.Add(cenaMala);
            groupBoxGolemina.Controls.Add(golema);
            groupBoxGolemina.Controls.Add(sredna);
            groupBoxGolemina.Controls.Add(mala);
            groupBoxGolemina.Location = new Point(12, 12);
            groupBoxGolemina.Name = "groupBoxGolemina";
            groupBoxGolemina.Size = new Size(277, 174);
            groupBoxGolemina.TabIndex = 1;
            groupBoxGolemina.TabStop = false;
            groupBoxGolemina.Text = "Големина";
            // 
            // cenaGolema
            // 
            cenaGolema.Location = new Point(146, 141);
            cenaGolema.Name = "cenaGolema";
            cenaGolema.Size = new Size(100, 23);
            cenaGolema.TabIndex = 1;
            cenaGolema.Text = "500";
            cenaGolema.TextChanged += cenaGolema_TextChanged;
            // 
            // cenaSredna
            // 
            cenaSredna.Location = new Point(146, 89);
            cenaSredna.Name = "cenaSredna";
            cenaSredna.Size = new Size(100, 23);
            cenaSredna.TabIndex = 1;
            cenaSredna.Text = "300";
            cenaSredna.TextChanged += cenaSredna_TextChanged;
            // 
            // cenaMala
            // 
            cenaMala.Location = new Point(146, 34);
            cenaMala.Name = "cenaMala";
            cenaMala.Size = new Size(100, 23);
            cenaMala.TabIndex = 1;
            cenaMala.Text = "200";
            cenaMala.TextChanged += cenaMala_TextChanged;
            // 
            // golema
            // 
            golema.AutoSize = true;
            golema.Location = new Point(20, 142);
            golema.Name = "golema";
            golema.Size = new Size(66, 19);
            golema.TabIndex = 1;
            golema.TabStop = true;
            golema.Text = "Голема";
            golema.UseVisualStyleBackColor = true;
            golema.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // sredna
            // 
            sredna.AutoSize = true;
            sredna.Location = new Point(20, 93);
            sredna.Name = "sredna";
            sredna.Size = new Size(65, 19);
            sredna.TabIndex = 1;
            sredna.TabStop = true;
            sredna.Text = "Средна";
            sredna.UseVisualStyleBackColor = true;
            sredna.CheckedChanged += sredna_CheckedChanged;
            // 
            // mala
            // 
            mala.AutoSize = true;
            mala.Location = new Point(20, 34);
            mala.Name = "mala";
            mala.Size = new Size(55, 19);
            mala.TabIndex = 1;
            mala.TabStop = true;
            mala.Text = "Мала";
            mala.UseVisualStyleBackColor = true;
            mala.CheckedChanged += mala_CheckedChanged;
            // 
            // groupBoxDodatoci
            // 
            groupBoxDodatoci.Controls.Add(cenaKecap);
            groupBoxDodatoci.Controls.Add(cenaEkstraSirenje);
            groupBoxDodatoci.Controls.Add(cenaFeferoni);
            groupBoxDodatoci.Controls.Add(checkBoxKecap);
            groupBoxDodatoci.Controls.Add(checkBoxEkstraSirenje);
            groupBoxDodatoci.Controls.Add(checkBoxFeferoni);
            groupBoxDodatoci.Location = new Point(307, 13);
            groupBoxDodatoci.Name = "groupBoxDodatoci";
            groupBoxDodatoci.Size = new Size(320, 174);
            groupBoxDodatoci.TabIndex = 2;
            groupBoxDodatoci.TabStop = false;
            groupBoxDodatoci.Text = "Додатоци";
            // 
            // cenaKecap
            // 
            cenaKecap.Location = new Point(180, 125);
            cenaKecap.Name = "cenaKecap";
            cenaKecap.Size = new Size(100, 23);
            cenaKecap.TabIndex = 5;
            cenaKecap.Text = "20";
            cenaKecap.TextChanged += cenaKecap_TextChanged;
            // 
            // cenaEkstraSirenje
            // 
            cenaEkstraSirenje.Location = new Point(180, 76);
            cenaEkstraSirenje.Name = "cenaEkstraSirenje";
            cenaEkstraSirenje.Size = new Size(100, 23);
            cenaEkstraSirenje.TabIndex = 4;
            cenaEkstraSirenje.Text = "30";
            cenaEkstraSirenje.TextChanged += cenaEkstraSirenje_TextChanged;
            // 
            // cenaFeferoni
            // 
            cenaFeferoni.Location = new Point(180, 30);
            cenaFeferoni.Name = "cenaFeferoni";
            cenaFeferoni.Size = new Size(100, 23);
            cenaFeferoni.TabIndex = 3;
            cenaFeferoni.Text = "40";
            cenaFeferoni.TextChanged += cenaFeferoni_TextChanged;
            // 
            // checkBoxKecap
            // 
            checkBoxKecap.AutoSize = true;
            checkBoxKecap.Location = new Point(20, 129);
            checkBoxKecap.Name = "checkBoxKecap";
            checkBoxKecap.Size = new Size(59, 19);
            checkBoxKecap.TabIndex = 2;
            checkBoxKecap.Text = "Кечап";
            checkBoxKecap.UseVisualStyleBackColor = true;
            checkBoxKecap.CheckedChanged += checkBoxKecap_CheckedChanged;
            // 
            // checkBoxEkstraSirenje
            // 
            checkBoxEkstraSirenje.AutoSize = true;
            checkBoxEkstraSirenje.Location = new Point(20, 80);
            checkBoxEkstraSirenje.Name = "checkBoxEkstraSirenje";
            checkBoxEkstraSirenje.Size = new Size(109, 19);
            checkBoxEkstraSirenje.TabIndex = 1;
            checkBoxEkstraSirenje.Text = "Екстра Сирење";
            checkBoxEkstraSirenje.UseVisualStyleBackColor = true;
            checkBoxEkstraSirenje.CheckedChanged += checkBoxEkstraSirenje_CheckedChanged;
            // 
            // checkBoxFeferoni
            // 
            checkBoxFeferoni.AutoSize = true;
            checkBoxFeferoni.Location = new Point(20, 34);
            checkBoxFeferoni.Name = "checkBoxFeferoni";
            checkBoxFeferoni.Size = new Size(84, 19);
            checkBoxFeferoni.TabIndex = 0;
            checkBoxFeferoni.Text = "Феферони";
            checkBoxFeferoni.UseVisualStyleBackColor = true;
            checkBoxFeferoni.CheckedChanged += checkBoxFeferoni_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(vkunpPivo);
            groupBox1.Controls.Add(vkupnoJP);
            groupBox1.Controls.Add(vkupnoKFS);
            groupBox1.Controls.Add(cenaPivo);
            groupBox1.Controls.Add(cenaJP);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cenaKFS);
            groupBox1.Controls.Add(kolicinaPivo);
            groupBox1.Controls.Add(kolicinaJP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(kolicinaKFS);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пијалок";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 18);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 14;
            label6.Text = "Вкупно";
            // 
            // vkunpPivo
            // 
            vkunpPivo.Location = new Point(498, 113);
            vkunpPivo.Name = "vkunpPivo";
            vkunpPivo.ReadOnly = true;
            vkunpPivo.Size = new Size(100, 23);
            vkunpPivo.TabIndex = 13;
            // 
            // vkupnoJP
            // 
            vkupnoJP.Location = new Point(498, 74);
            vkupnoJP.Name = "vkupnoJP";
            vkupnoJP.ReadOnly = true;
            vkupnoJP.Size = new Size(100, 23);
            vkupnoJP.TabIndex = 12;
            // 
            // vkupnoKFS
            // 
            vkupnoKFS.Location = new Point(498, 36);
            vkupnoKFS.Name = "vkupnoKFS";
            vkupnoKFS.ReadOnly = true;
            vkupnoKFS.Size = new Size(100, 23);
            vkupnoKFS.TabIndex = 11;
            // 
            // cenaPivo
            // 
            cenaPivo.Location = new Point(357, 113);
            cenaPivo.Name = "cenaPivo";
            cenaPivo.Size = new Size(100, 23);
            cenaPivo.TabIndex = 10;
            cenaPivo.Text = "80";
            cenaPivo.TextChanged += cenaPivo_TextChanged;
            // 
            // cenaJP
            // 
            cenaJP.Location = new Point(357, 74);
            cenaJP.Name = "cenaJP";
            cenaJP.Size = new Size(100, 23);
            cenaJP.TabIndex = 9;
            cenaJP.Text = "70";
            cenaJP.TextChanged += cenaJP_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 19);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "Цена";
            // 
            // cenaKFS
            // 
            cenaKFS.Location = new Point(357, 39);
            cenaKFS.Name = "cenaKFS";
            cenaKFS.Size = new Size(100, 23);
            cenaKFS.TabIndex = 7;
            cenaKFS.Text = "60";
            cenaKFS.TextChanged += cenaKFS_TextChanged;
            // 
            // kolicinaPivo
            // 
            kolicinaPivo.Location = new Point(209, 113);
            kolicinaPivo.Name = "kolicinaPivo";
            kolicinaPivo.Size = new Size(100, 23);
            kolicinaPivo.TabIndex = 6;
            kolicinaPivo.Text = "0";
            kolicinaPivo.TextChanged += kolicinaPivo_TextChanged;
            // 
            // kolicinaJP
            // 
            kolicinaJP.Location = new Point(209, 74);
            kolicinaJP.Name = "kolicinaJP";
            kolicinaJP.Size = new Size(100, 23);
            kolicinaJP.TabIndex = 5;
            kolicinaJP.Text = "0";
            kolicinaJP.TextChanged += kolicinaJP_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 19);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 4;
            label4.Text = "Количина";
            label4.Click += label4_Click;
            // 
            // kolicinaKFS
            // 
            kolicinaKFS.Location = new Point(209, 39);
            kolicinaKFS.Name = "kolicinaKFS";
            kolicinaKFS.Size = new Size(100, 23);
            kolicinaKFS.TabIndex = 3;
            kolicinaKFS.Text = "0";
            kolicinaKFS.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 113);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Пиво";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 1;
            label2.Text = "Сок од јаболко / портокал";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Кока кола/ Фанта / Спрајт";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listDeserts);
            groupBox2.Controls.Add(buttonOtkazi);
            groupBox2.Controls.Add(buttonNaracaj);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cenaDesert);
            groupBox2.Location = new Point(12, 354);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 175);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Десерт";
            // 
            // listDeserts
            // 
            listDeserts.FormattingEnabled = true;
            listDeserts.ItemHeight = 15;
            listDeserts.Items.AddRange(new object[] { "Овошна торта", "Сладолед", "Торта" });
            listDeserts.Location = new Point(6, 25);
            listDeserts.Name = "listDeserts";
            listDeserts.Size = new Size(138, 139);
            listDeserts.TabIndex = 0;
            listDeserts.SelectedIndexChanged += listDeserts_SelectedIndexChanged;
            // 
            // buttonOtkazi
            // 
            buttonOtkazi.Location = new Point(150, 138);
            buttonOtkazi.Name = "buttonOtkazi";
            buttonOtkazi.Size = new Size(153, 23);
            buttonOtkazi.TabIndex = 17;
            buttonOtkazi.Text = "Откажи";
            buttonOtkazi.UseVisualStyleBackColor = true;
            buttonOtkazi.Click += buttonOtkazi_Click;
            // 
            // buttonNaracaj
            // 
            buttonNaracaj.Location = new Point(150, 93);
            buttonNaracaj.Name = "buttonNaracaj";
            buttonNaracaj.Size = new Size(153, 23);
            buttonNaracaj.TabIndex = 16;
            buttonNaracaj.Text = "Нарачај";
            buttonNaracaj.UseVisualStyleBackColor = true;
            buttonNaracaj.Click += buttonNaracaj_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 25);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 15;
            label7.Text = "Цена на десерт:";
            // 
            // cenaDesert
            // 
            cenaDesert.Location = new Point(150, 50);
            cenaDesert.Name = "cenaDesert";
            cenaDesert.Size = new Size(153, 23);
            cenaDesert.TabIndex = 1;
            cenaDesert.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(zaVrakjanje);
            groupBox3.Controls.Add(naplateno);
            groupBox3.Controls.Add(vkupnoZaNaplata);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(327, 354);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 175);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Наплата";
            // 
            // zaVrakjanje
            // 
            zaVrakjanje.Location = new Point(144, 135);
            zaVrakjanje.Name = "zaVrakjanje";
            zaVrakjanje.Size = new Size(150, 23);
            zaVrakjanje.TabIndex = 23;
            zaVrakjanje.Text = "0";
            // 
            // naplateno
            // 
            naplateno.Location = new Point(144, 90);
            naplateno.Name = "naplateno";
            naplateno.Size = new Size(150, 23);
            naplateno.TabIndex = 22;
            naplateno.Text = "0";
            // 
            // vkupnoZaNaplata
            // 
            vkupnoZaNaplata.Location = new Point(144, 36);
            vkupnoZaNaplata.Name = "vkupnoZaNaplata";
            vkupnoZaNaplata.ReadOnly = true;
            vkupnoZaNaplata.Size = new Size(150, 23);
            vkupnoZaNaplata.TabIndex = 21;
            vkupnoZaNaplata.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 138);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 20;
            label10.Text = "За враќање:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 93);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 19;
            label9.Text = "Наплатено:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 39);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 18;
            label8.Text = "Вкупно за плаќање:";
            // 
            // Form1
            // 
            AcceptButton = buttonNaracaj;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonOtkazi;
            ClientSize = new Size(639, 541);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxDodatoci);
            Controls.Add(groupBoxGolemina);
            Name = "Form1";
            Text = "Form1";
            groupBoxGolemina.ResumeLayout(false);
            groupBoxGolemina.PerformLayout();
            groupBoxDodatoci.ResumeLayout(false);
            groupBoxDodatoci.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGolemina;
        private RadioButton golema;
        private RadioButton sredna;
        private RadioButton mala;
        private TextBox cenaGolema;
        private TextBox cenaSredna;
        private TextBox cenaMala;
        private GroupBox groupBoxDodatoci;
        private TextBox cenaKecap;
        private TextBox cenaEkstraSirenje;
        private TextBox cenaFeferoni;
        private CheckBox checkBoxKecap;
        private CheckBox checkBoxEkstraSirenje;
        private CheckBox checkBoxFeferoni;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox kolicinaKFS;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox vkunpPivo;
        private TextBox vkupnoJP;
        private TextBox vkupnoKFS;
        private TextBox cenaPivo;
        private TextBox cenaJP;
        private Label label5;
        private TextBox cenaKFS;
        private TextBox kolicinaPivo;
        private TextBox kolicinaJP;
        private ListBox listDeserts;
        private Button buttonOtkazi;
        private Button buttonNaracaj;
        private Label label7;
        private TextBox cenaDesert;
        private TextBox zaVrakjanje;
        private TextBox naplateno;
        private TextBox vkupnoZaNaplata;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}